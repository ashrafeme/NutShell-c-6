using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.Delegates {
    public delegate void ProgressReporter(int percentComplete);
    public class MulticastDelegates {


        private void HardWorker(ProgressReporter p) {
            for (int i = 0; i < 10; i++) {
                p(i * 10);
                System.Threading.Thread.Sleep(1000);
            }
        }

        public void TestHardWorker() {

            ProgressReporter p = WriteProgressToConsole;
            p += WriteProgressToFile;
            HardWorker(p);

        }

        private void WriteProgressToFile(int percentComplete)
            => System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());


        private void WriteProgressToConsole(int percentComplete)
            => Console.WriteLine(percentComplete);
    }
}
