using System;


namespace contra_cheque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            string enterprise_name = Console.ReadLine();
            int key_of_enterprise  =33;
            string cnpj ="1333,jjj-9";
            string andress = "Estrada Teresópolis ";
            
            Enterprise enterprise_1= new Enterprise(
                    enterprise_name,key_of_enterprise,
                    cnpj, andress);

            int    key_of_office    =  1;
            string name_of_office   = "progammer";
            float  salary_of_office =  3000;
            Office progammer = new Office(key_of_office,name_of_office,salary_of_office);

            
            string birth        = "10/10/1999";
            string name_of_employer         = "Carlos Henrique Cunha de Oliveira";
            int    registration = 202211;

            Employer empregado = new Employer(enterprise_1, 
                registration, name_of_employer, birth,progammer);
            
            string name_of_tribute = "FGTS";
            int    key_of_tribute  =  1;
            float  aliquot         = 2.0F;
            Tribute  FGTS   = new Tribute (name_of_tribute, aliquot,key_of_tribute);
            float value_of_fgts = FGTS.CalculeTributeValue(empregado.Office.Remuneration);
            Console.WriteLine($"Com o salário de {empregado.Office.Remuneration}, o fgts será de {value_of_fgts}");
        }
        
    }
    class Enterprise{
        public string Name;
        public string Cnpj {get;}
        public int    Key  {get;}
        public string Andress;

        public Enterprise(string enterprise_name, int key_of_enterprise, string cnpj, string andress ){
            this.Name    = enterprise_name;
            this.Key     = key_of_enterprise;
            this.Andress = andress;
            this.Cnpj    = cnpj;
    
        }


    }
    class Office{
        public int Key;
        public string Name;
        public float Remuneration{get;}

        public Office(int key_of_office, string name_of_office, float remuneration_base){
            this.Key            = key_of_office;
            this.Name           = name_of_office;
            this.Remuneration   = remuneration_base;
        }

        
    }
    class Tribute{
        public int    Key;
        public string Name;
        public float  Aliquot;
        public Tribute(string Name, float Aliquot, int Key){
            this.Name       = Name;
            this.Aliquot    = Aliquot;
            this.Key        = Key;

        }
        public float CalculeTributeValue (float salary){
            float value = (salary*Aliquot)/100;
            return value;

        }

    }
    class Employer{
        public Enterprise Enterprise_where_work;
        public Office     Office;
        public int    Registration;
        public string Name;
        public string Date_of_birth;
        

        public Employer(Enterprise Enterprise_where_work,
                        int registration, string name_of_employer, 
                        string date_of_birth, Office name_of_office){
            this.Enterprise_where_work    = Enterprise_where_work;
            this.Registration             = registration;
            this.Name                     = Name;
            this.Date_of_birth            = Date_of_birth;
            this.Office                   = name_of_office;
        }

    }
}


