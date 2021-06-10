
namespace ClassLibrary1
{
    public class Patient : Person, IHavePathology
    {
        private string FiscalCode { get; set; }
        private string pathology;
        public Patient(string name,string surname,int age,string fiscalCode,string phatology) : base( name,surname,age)
        {
            this.FiscalCode = fiscalCode;
            CheckPatology(pathology);
        }
        public string Pathology
        {
            get { return this.pathology;}
            set { CheckPatology(value); }
        }
        private void CheckPatology(string pathology)
        {
            if (pathology != PATHOLOGY.Cardiac.ToString() ||
                pathology != PATHOLOGY.Tumor.ToString() ||
                pathology != PATHOLOGY.Pulmonary.ToString())
            {
                this.pathology = pathology ;
            }
            else
                this.pathology = pathology;
        }
        public bool GetPathology()
        {
            if (this.pathology == null)
                return false;
            else
                return true;
        }
        
    }
}
