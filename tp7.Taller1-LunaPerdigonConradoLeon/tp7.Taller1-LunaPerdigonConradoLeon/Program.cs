using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7.Taller1_LunaPerdigonConradoLeon
{

    public enum elcargo
    {
        Auxiliar, Administrativo, Ingeniero, Especialista, Investigador
    }
    public enum elgenero
    {
        Masculino, Femenino
    }
    public enum elestadocivil
    {
        Soltero, Casado, Viudo, Otro
    }

    public struct fechas
    {
        public int dia;
        public int mes;
        public int anio;

    }

    

    public struct empleado
    {

        public string nombre;
        public string apellido;
        public elestadocivil estadocivil;
        public elgenero genero;
        public elcargo cargo;
        public fechas fechanacimiento;
        public fechas fechaingreso;
        public double sueldo;



        public empleado(string _nombre, string _apellido, elestadocivil _estadocivil, double _sueldo, elgenero _genero, elcargo _cargo, fechas _fechanacimiento, fechas _fechaingreso)
        {
            nombre = _nombre;
            apellido = _apellido;
            estadocivil = _estadocivil;
            cargo = _cargo;
            genero = _genero;
            sueldo = _sueldo;
            fechanacimiento = _fechanacimiento;
            fechaingreso = _fechaingreso;

        }


        public void mostrarcontacto()
        {
            Console.WriteLine(nombre);
            Console.WriteLine(apellido);
            Console.WriteLine(estadocivil);
            Console.WriteLine(genero);
            Console.WriteLine(cargo);
            Console.WriteLine(sueldo);
            Console.WriteLine(@"{0}  / {1} / {2}", fechanacimiento.dia, fechanacimiento.mes, fechanacimiento.anio);
            Console.WriteLine(@"{0}  / {1}  / {2}", fechaingreso.dia, fechaingreso.mes, fechaingreso.anio);
            Console.WriteLine("--------------");
        }


        //el fin de la estructura
        //public int elanio_actual =2019;

        public int aniosTrabajados(int anio_actual)
        {
            return anio_actual - fechaingreso.anio;

        }


        public int edadEmpleado(int anio_actual)
        {
            return anio_actual - fechanacimiento.anio;
        }

        public int antiguedad(int anio_actual)
        {
            return anio_actual - fechaingreso.anio;
        }

        public void aniosJubilacion(int anio_actual)
        {
            int aniosParajubilacion;

            if (genero == elgenero.Masculino)
            { //si es masculino
                aniosParajubilacion = 65 - edadEmpleado(2019);
                Console.WriteLine("El empleado se jubilara  {0} anios", aniosParajubilacion);
            }

            if (genero == elgenero.Femenino)
            {//si es femenino
                aniosParajubilacion = 60 - edadEmpleado(2019);
                Console.WriteLine("El empleado se jubilara  {0} anios", aniosParajubilacion);
            }
        }


       
    }

    class Program
    {

        static void Main(string[] args)
        {
           
            List<empleado> listaempleados = new List<empleado>();//Creo la agenda
           
            
            listaempleados.Add(new empleado());
           
            //cargardatos();
            //listaempleados.ForEach(y => y.cargardatos());
           


            listaempleados.Add(new empleado() { nombre = "Jaimito", apellido = "Lopez" ,sueldo= 123.2 });
            listaempleados.ForEach(x => x.mostrarcontacto());
            
           


            Console.ReadKey();
        }


        public empleado cargardatos()
        {
            Random rnd = new Random();
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            string nombre = "jaimito";
            string apellido = "lopez";
            int opcion = rnd.Next(1, 3);
            elgenero generoX;
            switch (opcion)
            {
                case 1:
                    generoX = elgenero.Masculino;
                    break;
                case 2:
                    generoX = elgenero.Femenino;
                    break;
                default:
                    generoX = elgenero.Masculino;
                    break;
            }

            int opcion1 = rnd1.Next(1, 6);
            elcargo cargox;
            switch (opcion1)
            {
                case 1:
                    cargox = elcargo.Administrativo;
                    break;
                case 2:
                    cargox = elcargo.Auxiliar;
                    break;
                case 3:
                    cargox = elcargo.Especialista;
                    break;
                case 4:
                    cargox = elcargo.Ingeniero;
                    break;
                case 5:
                    cargox = elcargo.Investigador;
                    break;
                default:
                    cargox = elcargo.Auxiliar;
                    break;

            }
            double sueldo = rnd2.Next(5000, 10000);
            Random rnd3 = new Random();
            int opcion3 = rnd3.Next(1, 5);
            elestadocivil estadocivilx;
            switch (opcion3)
            {
                case 1:
                    estadocivilx = elestadocivil.Soltero;
                    break;
                case 2:
                    estadocivilx = elestadocivil.Casado;
                    break;
                case 3:
                    estadocivilx = elestadocivil.Viudo;
                    break;
                case 4:
                    estadocivilx = elestadocivil.Otro;
                    break;
                default:
                    estadocivilx = elestadocivil.Soltero;
                    break;
            }

            fechas lafechadenacimiento;
            Random fecharandom1 = new Random();
            lafechadenacimiento.dia = fecharandom1.Next(1,31);
            Random fecharandom2 = new Random();
            lafechadenacimiento.mes = fecharandom2.Next(1, 13);
            Random fecharandom3 = new Random();
            lafechadenacimiento.anio = fecharandom3.Next(1965, 1998);

            fechas lafechadeingreso;
          
            lafechadeingreso.dia = fecharandom1.Next(1, 31);
            
            lafechadeingreso.mes = fecharandom2.Next(1, 13);
           
            lafechadeingreso.anio = fecharandom3.Next(1965, 1998);
      
            /*DateTime fechaactual = new DateTime(1965, 1, 1);
            DateTime fechainicial = new DateTime(1994, 1, 1);

            TimeSpan rango=(fechaactual - fechainicial);

            int diferenciadedias = rango.Days;
            Random rand = new Random();
            int valoraleatorio = rand.Next(diferenciadedias);
         
            DateTime fechaaleatoria = fechainicial.AddYears(valoraleatorio);     
            */
            empleado emp= new empleado(nombre, apellido, estadocivilx, sueldo, generoX, cargox,lafechadenacimiento, lafechadeingreso);
            return emp;
        }

        public static double elsueldo(empleado emp)
         {
                  double adicional=0.0, salario=0.0;

                    if((2019 - emp.fechaingreso.anio) >= 20)
                        salario =  emp.sueldo * 0.25;
                    else
                    salario = emp.sueldo * 0.02 * (2019 - emp.fechaingreso.anio);

                    if( emp.estadocivil == elestadocivil.Casado)//Casado
                        adicional= adicional + 5000;
                    else
                        adicional= adicional * 0.50;
                

                salario= salario + adicional;
            return salario;

        }

            /*

            public static void operacionesEdad(List<empleados> elempleado)
            {
                /*
                 DateTime fechaactual=DateTime.Now();
                 Console.WriteLine("fecha", fechaactual.ToSting());
                  
                  
                 Timespan tiempotrabajado = DateTime.Now - DateTime.Parse(fechaingreso.anio, fechaingreso.mes, fechaingreso.anio);
                 int diferenciadias= tiempotrabajado.Days;
                  Random rand= new random();
                  
                Console.WriteLine("Los años que trabajo del empleado es: ", tiempotrabajado.ToString());
                DateTime edadempleado = DateTime.Today - DateTime.Parse(fechanacimiento.anio, fechanacimiento.mes, fechanacimiento.dia);
                Console.WriteLine("La edad del empleado es: ", edadempleado.ToString());

                
 
         
         
 */

       
    }
}
    
