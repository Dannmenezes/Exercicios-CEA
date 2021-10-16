using System;

namespace Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double n1;
            double n2;
            double n3;
            double n4;
            double resultado;
            Program program = new Program();

            Console.WriteLine("##Sejam bem vindo aos exercicios do C&A Fshion Devs###");

            do { 
                
                Console.WriteLine("Qual exercício você gostaria de ver?");
                Console.WriteLine("(1) Calculadora IMC");
                Console.WriteLine("(2) Calculo Salário");
                Console.WriteLine("(3) Calculo Esfera do Raio R");
                Console.WriteLine("(4) Calculo Média Alunos");
                Console.WriteLine("(5) Programa Animais de Estimação");

                Console.WriteLine("Digite a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());

            
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite seu peso atual:");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite sua altura: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.resultado(n1, n2);
                        Console.WriteLine("O meu IMC atual é {0:0.00}", resultado);

                        if (resultado < 20)
                        {
                            Console.WriteLine("Você está abaixo do peso");
                        }
                        else if ((resultado < 20) && (resultado < 25))
                        {
                            Console.WriteLine("Você está no seu peso ideal");
                        }
                        else if (resultado >= 25)
                        {
                            Console.WriteLine("Você está acima do seu peso ideal");
                        }
                        break;

                    //Exercicio 2 

                    case 2:
                        Console.WriteLine("Digite o seu salário: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o valor do Salário Minimo atualmente: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.salario(n1, n2);
                        Console.WriteLine("Atualmente você recebe {0} salários minimos", resultado);
                        break;

                    //Exercicio 3

                    case 3:
                        Console.WriteLine("Insira o raio R da esfera: ");
                        n1 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.volume(n1);
                        Console.WriteLine("O volume da esfera é {0}", resultado);
                        break;

                    //Exercicio 4

                    case 4:
                        Console.WriteLine("Para verificar a sua média, insira o valor das suas notas abaixo: ");
                        Console.WriteLine("Nota da prova 1");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nota da prova 1");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nota da prova 1");
                        n3 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.media(n1, n2, n3);
                        Console.WriteLine("Sua média é {0}", resultado);

                        if (resultado >= 7)
                        {
                            Console.WriteLine("Você está aprovado");
                        } else 
                        {
                            Console.WriteLine("Insira sua nota de exame: ");
                            n4 = Convert.ToDouble(Console.ReadLine());
                            resultado = program.exame(resultado, n4);
                            Console.WriteLine("Sua nova média é {0}", resultado);

                            if (resultado >= 5)
                            {
                                Console.WriteLine("Você está aprovado");
                            } else 
                            {
                                Console.WriteLine("Você está reprovado");
                            }
                        }
                        break;

                    //Exercicio 5 

                    case 5:

                        string animalNome;
                        string animalTipo;
                        int cachorroContador = 0, gatoContador = 0, peixeContador = 0;

                        Console.WriteLine("Insira o nome do seu primeiro animal de estimação: ");
                        animalNome = Console.ReadLine();
                        Console.WriteLine("Insira o tipo do seu animal de estimação: ");
                        animalTipo = Console.ReadLine();

                        Animal animal1 = new Animal(animalNome, animalTipo);

                        if (animal1.getTipo().ToLower() == "cachorro")
                        {
                            cachorroContador++;
                        }
                        else if (animal1.getTipo().ToLower() == "gato")
                        {
                            gatoContador++;
                        } else
                        {
                            peixeContador++;
                        }

                        Console.WriteLine("Insira o nome do seu primeiro animal de estimação: ");
                        animalNome = Console.ReadLine();
                        Console.WriteLine("Insira o tipo do seu animal de estimação: ");
                        animalTipo = Console.ReadLine();

                        Animal animal2 = new Animal(animalNome, animalTipo);

                        if (animal2.getTipo().ToLower() == "cachorro")
                        {
                            cachorroContador++;
                        }
                        else if (animal2.getTipo().ToLower() == "gato")
                        {
                            gatoContador++;
                        }
                        else
                        {
                            peixeContador++;
                        }


                        Console.WriteLine("Insira o nome do seu primeiro animal de estimação: ");
                        animalNome = Console.ReadLine();
                        Console.WriteLine("Insira o tipo do seu animal de estimação: ");
                        animalTipo = Console.ReadLine();

                        Animal animal3 = new Animal(animalNome, animalTipo);

                        if (animal3.getTipo().ToLower() == "cachorro")
                        {
                            cachorroContador++;
                        }
                        else if (animal3.getTipo().ToLower() == "gato")
                        {
                            gatoContador++;
                        }
                        else
                        {
                            peixeContador++;
                        }

                        Console.WriteLine("Insira o nome do seu primeiro animal de estimação: ");
                        animalNome = Console.ReadLine();
                        Console.WriteLine("Insira o tipo do seu animal de estimação: ");
                        animalTipo = Console.ReadLine();

                        Animal animal4 = new Animal(animalNome, animalTipo);

                        if (animal4.getTipo().ToLower() == "cachorro")
                        {
                            cachorroContador++;
                        }
                        else if (animal4.getTipo().ToLower() == "gato")
                        {
                            gatoContador++;
                        }
                        else
                        {
                            peixeContador++;
                        }

                        Console.WriteLine("Insira o nome do seu primeiro animal de estimação: ");
                        animalNome = Console.ReadLine();
                        Console.WriteLine("Insira o tipo do seu animal de estimação: ");
                        animalTipo = Console.ReadLine();

                        Animal animal5 = new Animal(animalNome, animalTipo);

                        if (animal5.getTipo().ToLower() == "cachorro")
                        {
                            cachorroContador++;
                        }
                        else if (animal5.getTipo().ToLower() == "gato")
                        {
                            gatoContador++;
                        }
                        else
                        {
                            peixeContador++;
                        }


                        Console.WriteLine("Verifique abaixo, os tipos de animais de estimação que você possue:");
                        Console.WriteLine("Cachorro {0}", cachorroContador);
                        Console.WriteLine("Gato {0}", gatoContador);
                        Console.WriteLine("Peixe {0}", peixeContador);

                        break;
                }

            } while (true);
        }    
        public double resultado (double n1, double n2)
        {
            return (n1 / (n2*n2));
        }
        public double salario (double n1, double n2)
        {
            return (n1 / n2);
        }

        public double volume (double n1)
        {
            const double pi = 3.14159;
            return (4 * pi * Math.Pow(n1, 3)) / 3;
        }

        public double media(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3 / 3);
        }

        public double exame(double resultado, double n4)
        {
            return (resultado + n4 / 2);
        }          
    }
}
