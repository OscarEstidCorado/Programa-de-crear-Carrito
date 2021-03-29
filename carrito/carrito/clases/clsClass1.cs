using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrito.clases
{
    class clsClass1
    {
        public String marca { get;  }

        public int vel_max { get;  }

        private int vel_actual { get; set; }

        private bool encendido  = false;

        public String color { get; set; }



        public string diredere()
        {
            if (encendido)
            {
                return "Luz de Emergencia Derecha";
            }
            else
            {
                encendido = false;


                return "Carro Esta Apagado";
            }

        }


        public string direizqui()
        {
            if (encendido)
            {
                return "Luz de Emergencia Izquierda";
            }
            else
            {
                encendido = false;


                return "Carro Esta Apagado";
            }
            
        }

        public string frenare()
        {
            

            if (vel_actual == 0)
            {
                return "EL Carro se a Detenido";
            }
            else
            {
                vel_actual -= 10;
                return $"Se Redujo la velocidad a {vel_actual} KPH";
            }
        }
        

        public string acelerar()
        {
            vel_actual = vel_actual + 10;


             if(vel_actual > vel_max)
            {
                
                return "Lo lamento llegaste a la velocidad Maxima";
            }
             else
            {
                if (vel_actual == 30)
                {
                    return "Coloque la Segunda Velocidad";
                }

                if (vel_actual == 60)
                {
                    return "Coloque la Tercera Velocidad";
                }

                if (vel_actual == 90)
                {
                    return "Coloque la Cuarta Velocidad";
                }

                if (vel_actual == 120)
                {
                    return "Coloque la Quinta Velocidad";
                }

                return $"vas a {vel_actual} KPH";
            
            }

            

        }
         
        public bool estaencendido()
        {
            return encendido;
            
        }

        public clsClass1(string marcacarro, int velocidadmx)
        {
            this.marca = marcacarro;
            this.vel_max = velocidadmx;
            

        }

        public string Apagarmotor()
        {
            if (encendido)
            {
                return "EL Carro se Apago";
            }
            else
            {
                encendido = false;
                

                return "Carro Esta Apagado";
            }
        }

        public string Encendermotor()
        {

            

            if(encendido)
            {
                return "El Carro ya se encuentra encendido";
            }
            else
            {
                encendido = true;
                vel_actual = 0;

                return "Listo!! El Carro se encendio";
            }


            
        }

    }
}
