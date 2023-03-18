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


            
    }
}