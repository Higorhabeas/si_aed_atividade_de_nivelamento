using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {          
            Exercicio_1();
            //Exercicio_2();
            //Exercicio_3();
            //Exercicio_4();
            //Exercicio_5();
            //Exercicio_6();
            //Exercicio_7();
            //Exercicio_8();
            //Exercicio_9();
            //Exercicio_10();
        
        }

        static void Exercicio_1()
        {
            double soma = 0;
            double media;
            for (int i = 1; i <=5; i++){
                Console.Write("\nDigite idade do aluno: ");
                double idade = double.Parse(Console.ReadLine());
                soma += idade;
                
            }
            media = soma / 5;
            Console.WriteLine("\nA média é:  {0}",media);
            Console.ReadKey();
        }

        static void Exercicio_2()        
        {
            Console.Write("\nDigite o número para verificação :");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0){
                Console.WriteLine("\nEste número é par!");
            }else{
                Console.WriteLine("\nEste número é impar!");
            }
        }

        static void Exercicio_3(){
            int[] idades = {18, 15, 25, 22, 21, 45, 33, 16, 17, 20};
            int qtde_maior_18 = 0;
            for (int i = 0; i < idades.Length; i++){
                if (idades[i] > 18)
                qtde_maior_18 ++;
            }
            Console.WriteLine("\nA quantidade de alunos maiores de 18 anos é:   {0}",qtde_maior_18);
            Console.ReadKey();
        }

        static void Exercicio_4(){
            int matriculaAlunoMaisAlto = 0;
            double alturaAlunoMaisAlto = 0;

            int matriculaAlunoMaisBaixo = 0;
            double alturaAlunoMaisBaixo = 5;

            for (int i = 1; i <= 10; i++){
                Console.WriteLine($" Aluno {i}:");
                Console.Write("\nDigite a matrícula do aluno: ");
                int matriculaLida = int.Parse(Console.ReadLine());

                Console.Write("\nDigite a altura do aluno em metros: ");
                double alturaLida = double.Parse(Console.ReadLine());

                if( alturaLida > alturaAlunoMaisAlto){
                    alturaAlunoMaisAlto = alturaLida;
                    matriculaAlunoMaisAlto = matriculaLida;
                }

                if (alturaLida < alturaAlunoMaisBaixo){
                    alturaAlunoMaisBaixo = alturaLida;
                    matriculaAlunoMaisBaixo = matriculaLida;
                }
            }

            Console.WriteLine("\nA matricula do aluno mais alto: " + matriculaAlunoMaisAlto);
            Console.WriteLine("\nA matriculo do aluno mais baixo: " + matriculaAlunoMaisBaixo);
        }

        static void Exercicio_5(){
            double resultado;
            Console.Write("Digite o simbolo da operação matemática: ");
            string operacao = Console.ReadLine();

            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (operacao){
                case "+":
                    resultado = num1 + num2;
                    Console.WriteLine("\nA soma do número " + num1 + " com o " + num2 + " é: " + resultado);
                    break;
                case "-":
                    resultado = num1 - num2;
                    Console.WriteLine("\nA subitração do número " + num1 + " com o " + num2 + " é: " + resultado);
                    break;
                case "*":
                    resultado = num1 * num2;
                    Console.WriteLine("\nA multiplicação do número " + num1 + " com o " + num2 + " é: " + resultado);
                    break;
                case "/":
                    if (num2 == 0){
                        Console.WriteLine("Não podemos fazer divisão por zero");
                    }else{
                        resultado = num1 / num2;
                        Console.WriteLine("\nA divisão do número " + num1 + " com o " + num2 + " é: " + resultado);
                    }
                    break;
                case "^":
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine("\nA Potenciação do número " + num1 + " com o " + num2 + " é: " + resultado);
                    break;
                case "r":
                    if (num1 < 0){
                        Console.WriteLine("Não podemos fazer radiciação com números negativos.");
                    }else{
                        resultado = Math.Pow(num1, 1.0 / num2);
                    Console.WriteLine("\nA radiciaçao do número " + num1 + " com o " + num2 + " é: " + resultado);
                    }
                    break;
            }
        }
    
        static void Exercicio_6(){
            Console.Write("Digite a idade do usuário: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade < 0){
                Console.Write("\nDigite uma idade maior que zero: ");
                idade = int.Parse(Console.ReadLine());
                if(idade < 18){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem Permissão");
                }else{
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Permissão concedida");
                }
            }else if(idade < 18){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem Permissão");
            }else{
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Permissão concedida");
            }
             Console.ResetColor();
        }
    
        static void Exercicio_7(){
            Console.Write("Digite uma frase qualquer: ");
            string frase = Console.ReadLine();
            char [] letras = frase.ToCharArray();
            for (int i = 0; i < letras.Length; i++){
                if (letras[i] == 'A' || letras[i] == 'a') {
                    letras[i] = '&';
                }
            }
            Console.WriteLine("Frase modificada: " +  new string(letras));
        }

        static void Exercicio_8(){
            double novoSalario;
            Console.Write("Digite o valor do salário a ser reajustado: ");
            double salario = double.Parse(Console.ReadLine());
            if (salario <= 1700) {
                novoSalario = salario + 300;
            }else{
                novoSalario = salario + 200;
            }

            Console.WriteLine("O novo salário é: " + novoSalario);
        }

        static void Exercicio_9(){
            Console.WriteLine("Digite o nome do usuário: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o e-mail do usuário: ");
            string email = Console.ReadLine();

            Console.WriteLine("Digite o telefone do usuário: ");
            string telefone = Console.ReadLine();

            Console.WriteLine("Digite o RG do usuário: ");
            string rg = Console.ReadLine();

            string infoUsuario = $"Nome: {nome}\n E-mail: {email}\n Telefone: {telefone}\n RG: {rg}";

            File.WriteAllText("informacoes_usuario.txt",infoUsuario);

            Console.WriteLine("Informações gravadas com sucesso!");

            try{
                string informacaoUsuario = File.ReadAllText("informacoes_usuario.txt");

                Console.WriteLine("Informações do usuário: ");
                Console.WriteLine(informacaoUsuario);
            }
            catch (FileNotFoundException) {
                Console.WriteLine("Arquivo não encontrado.");
            }
            catch (Exception ex){
                Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {ex.Message}");
            }
        }

        static void Exercicio_10(){
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Cadastrar novo IMC");
            Console.WriteLine("2 - Consultar registro existente");
            Console.WriteLine("0 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao){
                case 1:
                    CadastrarIMC();
                    break;
                case 2:
                    ConsultarRegistro();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        static void CadastrarIMC(){
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o peso em kg : ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = CalcularIMC(peso, altura);

            string registro = $"{nome},{idade},{peso},{altura},{imc}";

            File.AppendAllText("imc.txt", registro + Environment.NewLine);
            
            Console.WriteLine("IMC calculado e registrado com sucesso!");

        }

        static double CalcularIMC(double peso, double altura){
            return peso / Math.Pow(altura, 2);
        }

        static void ConsultarRegistro(){
            try {
                string [] resgistosIMC = File.ReadAllLines("imc.txt");

                Console.WriteLine("Registros do arquivo IMC:");

                foreach (string registro in resgistosIMC){
                    string[] campo = registro.Split(',');
                    string nome = campo[0];
                    int idade = int.Parse(campo[1]);
                    double peso = double.Parse(campo[2]);
                    double altura = double.Parse(campo[3]);
                    double imc = double.Parse(campo[4]);
                    Console.WriteLine($"Nome: {nome}, Idade: {idade}, Peso: {peso}, Altura: {altura}, IMC: {imc}");

                }
            }
            catch (FileNotFoundException){
                Console.WriteLine("Não foi encontrado nenhum registro.");
            }

            catch (Exception ex){
                Console.WriteLine($"Erro ao ler o arquivo :{ex.Message}");
            }
        }
    }
}
