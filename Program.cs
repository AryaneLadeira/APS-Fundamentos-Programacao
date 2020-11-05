using System;

namespace C_
{
    class Program
    {

        static void Main(string[] args)
        {

            double encomenda, pesoenc, cargamax1, pesomaior;
            string nome, NomeMaiorPeso;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua carga máxima: ");
            cargamax1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o peso da encomenda: ");
            pesoenc = Convert.ToDouble(Console.ReadLine());

            pesomaior = pesoenc;
            NomeMaiorPeso = nome;
            
            if(pesoenc <= 0){
                Console.WriteLine("{0} foi quem carregou o maior peso.", NomeMaiorPeso);
            
            }
                else if (pesoenc == cargamax1){ //se o entregador tiver a carga max = enc passa pro proximo entregador com 0
                encomenda = 0;
                ProximoCiclista(encomenda, pesoenc, pesomaior, nome, NomeMaiorPeso);
            }
               else if (pesoenc < cargamax1)
            {
                encomenda = UltrapassarLimite(cargamax1, pesoenc);
                ProximoCiclista(encomenda, pesoenc, pesomaior, nome, NomeMaiorPeso); 
            }
            else
            {
                encomenda = pesoenc;
                ProximoCiclista(encomenda, pesoenc, pesomaior, nome, NomeMaiorPeso);
            }
        }
        static void ProximoCiclista(double encomenda, double pesoenc, double pesomaior, string nome, string NomeMaiorPeso ){
            
            
            while (pesoenc > 0 && encomenda >=0)
            {
                double cargamax;
                if(encomenda > 0){
                    Console.WriteLine("Você recebeu uma encomenda de {0}kg.", encomenda);
                }

                Console.WriteLine("Novo entregador! Digite seu nome: ");
                nome = Console.ReadLine();


                Console.WriteLine("Digite sua carga máxima: ");
                cargamax = Convert.ToDouble(Console.ReadLine());

                if(cargamax < encomenda){
                    ProximoCiclista(encomenda, pesoenc, pesomaior, nome, NomeMaiorPeso);
                }

                encomenda = UltrapassarLimite(cargamax, encomenda);

                if (pesoenc > pesomaior)
                {
                    pesomaior = pesoenc;
                    NomeMaiorPeso = nome;
                }
                
            }

            Console.WriteLine("{0} foi quem carregou o maior peso.", NomeMaiorPeso);
            
        }
        

        static double UltrapassarLimite(double cargamax, double pesoenc)
        {
            double pesoprox;

            while (pesoenc < cargamax)
            {
                Console.WriteLine("Digite o peso da encomenda: ");
                pesoprox = Convert.ToDouble(Console.ReadLine());
                
                if (pesoprox <= 0)
                {
                    return -1;
                }
                else if (pesoprox + pesoenc == cargamax)
                {
                    return 0;
                }
                else if (pesoprox + pesoenc > cargamax)
                {
                    return pesoprox;
                }
                else
                {
                    pesoenc += pesoprox;
                }


            } return pesoenc;

        }

    }
            

    }