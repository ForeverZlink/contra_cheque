using System;


namespace contra_cheque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Digite o nome da empresa:\t");
            string enterprise_name = Console.ReadLine();
            int key_of_enterprise  =33;
            string cnpj ="1333,jjj-9";
            string andress = "Estrada Teresópolis ";
            Enterprise enterprise_1= new Enterprise(
                    enterprise_name,key_of_enterprise,
                    cnpj, andress);
            
            string birth        = "10/10/1999";
            string name         = "Carlos Henrique Cunha de Oliveira";
            int    registration = 202211;
            Employer empregado = new Employer(enterprise_1, 
                registration, name, birth);
            Console.WriteLine(empregado.Enterprise_where_work.Name,enterprise_name);
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

    }
    class Employer{
        public Enterprise Enterprise_where_work;
        public int    Registration;
        public string Name;
        public string Date_of_birth;

        public Employer(Enterprise Enterprise_where_work, int registration, string name_of_employer, string date_of_birth){
            this.Enterprise_where_work    = Enterprise_where_work;
            this.Registration             = registration;
            this.Name                     = Name;
            this.Date_of_birth            = Date_of_birth;
        }
    }
}


