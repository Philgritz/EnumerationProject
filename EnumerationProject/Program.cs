using System;

namespace EnumerationProject {

    enum GradStatus { Summa, Magna, CumLaude }  //defines type, possible values, defaults to 0,1,2

    class Program {
        static void Main(string[] args) {

            GradStatus gs = GradStatus.Magna;
            var i = (int)gs;    // casting-- turns one type into another.  (Changing int to double)

            if(gs == GradStatus.Magna) {

            }
            


        }
    }
}
