using System;


namespace Pots_Model
{
    public class Pots
    {
        #region Fields
        public int n_equilib;
        public int L;  // the dimension of Latice
        public int[,] spin;
        public int E, M;
        public double T, C, X, E_ave, M_ave, E2_ave, M2_ave;
  
        public double[] data = new double[4];
        public int accept, n_countingE;
        public int mcs ; // montecarlo steps
        public double norm;


        public int q;   // 

        int N; // that N = L*L  the number of spin that must be filped in ecah monte carlo step.
        double[] W_ratio = new double[9]; // because we have de = {-4,-3,-2,-1,0,1,2,3,4};  for q >= 2
        Random rand = new Random();
        int[] tempRandomArr;
        int spinNew;

       
        
        #endregion



        public Pots(int L, int q, int mcs, int n_equilib)
        {
            this.L = L;
            this.q = q;
            this.mcs = mcs;
            this.n_equilib = n_equilib;
            if (q < 4)
                tempRandomArr = new int[q - 1];  // because if q >= 4,  we dont need tempRandomArr
            InitalizeSpins();
        }

        private void InitalizeSpins()
        {
            spin = new int[L, L];
            int i, j;
            for (i = 0; i < L; i++)
                for (j = 0; j < L; j++)
                    spin[i, j] = rand.Next(q);

            E = 0; M = 0; accept = 0;
            N = L * L;
            norm = 1.0 / (N * mcs);

            int right, up;
            for (i = 0; i < L; i++)
            {
                right = (i == L - 1) ? 0 : i + 1;
                for (j = 0; j < L; j++)
                {
                    up = (j == L - 1) ? 0 : j + 1;
                    E += -(Delta(spin[i, j], spin[right, j]) + Delta(spin[i, j], spin[i, up]));
                    M += spin[i, j];
                }
            }

           
        }


        private void MetroPolice()
        {
            int i, j, de;
            bool changedEnergy;

            for (int k = 0; k < N; k++)
            {
                i = rand.Next(L);
                j = rand.Next(L);

                de = DeltaE(i, j);
                changedEnergy = false;
                if (de <= 0)
                    changedEnergy = true;
                else
                    if (rand.NextDouble() <= W_ratio[de + 4])
                        changedEnergy = true;

                if (changedEnergy)
                {
                    M += spinNew - spin[i, j];
                    E += de;
                    spin[i, j] = spinNew;
                    accept++;
                }
            }
        }


        private int DeltaE(int i, int j)
        {
            int right = (i == L - 1) ? 0 : i + 1;
            int up = (j == L - 1) ? 0 : j + 1;

            int left = (i == 0) ? L - 1 : i - 1;
            int down = (j == 0) ? L - 1 : j - 1;

            int s = spin[i, j];

            if (q < 4)  // 
            {
                for (int value = 0, v = 0; value < q; value++)
                {
                    if (value != s)
                        tempRandomArr[v++] = value;
                }
                spinNew = tempRandomArr[rand.Next(q - 1)];
            }
            else
                do { spinNew = rand.Next(q); } while (spinNew == s);

            return -(Delta(spinNew, spin[right, j]) + Delta(spinNew, spin[left, j]) +
                        Delta(spinNew, spin[i, up]) + Delta(spinNew, spin[i, down])) +

                      (Delta(s, spin[right, j]) + Delta(s, spin[left, j]) +
                        Delta(s, spin[i, up]) + Delta(s, spin[i, down]));

        }

        private void InitData()
        {
            accept = 0;
            for (int i = 0; i < data.Length; i++)
                data[i] = 0;
        }

        private void CalculateData()
        {
            n_countingE++;
            data[0] += E * norm; // just for avoiding big number we product norm  :  norm = 1/(N*mcs)
            data[1] += E * (E * norm); // per spin
            data[2] += M * norm;
            data[3] += M * (M * norm);
        }


        private int Delta(int x, int y)
        {
            if (x == y) return 1;
            return 0;
        }

        public void InitializeSimulation(double currentT, FormProgress formProgress)
        {
            int i, de;
            T = currentT;
            n_countingE = 0;
            for (de = -4; de <= 4; de++)
                W_ratio[(de + 4)] = Math.Exp(-de / T);

            for (i = 0; i < n_equilib; i++ )
            {
                MetroPolice();  // this part acting when currner T is Tfirst.
                double progress = (double)(i + 1) / n_equilib;
                if(formProgress != null && !formProgress.IsDisposed)
                formProgress.BeginInvoke((System.Threading.ThreadStart)delegate
                    {
                        formProgress.DoingLoad(progress);
                    });
            }

            InitData();
            CalculateData();
        }


        public void InitializeSimulation(double currentT, bool isFirstT)
        {
            int i, de;
            T = currentT;
            n_countingE = 0;
            for (de = -4; de <= 4; de ++)
                W_ratio[(de + 4)] = Math.Exp(-de / T);

            if (isFirstT)
                for (i = 0; i < n_equilib; i++)
                    MetroPolice();  // this part acting when currner T is Tfirst.

            InitData();
            CalculateData();
        }


        public void DoOneMonteCarloStep()
        {
            MetroPolice();
            CalculateData();
        }

        public void CalculateAverageParameters()
        {
            E_ave = (data[0] * mcs) / n_countingE;
            E2_ave = (data[1] * mcs) / n_countingE;
            M_ave = (data[2] * mcs) / n_countingE;
            M2_ave = (data[3] * mcs) / n_countingE;         // just for avoiding big number for E and M
            

            C = (E2_ave - E_ave * E_ave * N) / (T * T);  // per spin
            X = (M2_ave - M_ave * M_ave * N) / T;       // per spin
        }


    }
}
