namespace log_LineComparisionProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {

            WelcomeToLineComputationProblem welcome = new WelcomeToLineComputationProblem();
            welcome.WelcometoLineComputation();


            LineComparisionProblem_UseCase1 Uc1 = new LineComparisionProblem_UseCase1();
            Uc1.LineComparisionProblemUC1();


            EqualityOfTwoLines_UseCase2 Uc2 = new EqualityOfTwoLines_UseCase2();
            Uc2.EqualityOfTwoLines_UC1();

            ComparisionOfLines_Usecase3 Uc3 = new ComparisionOfLines_Usecase3();
            Uc3.ComparisonofLines_UC3();
        }
 
    }
}