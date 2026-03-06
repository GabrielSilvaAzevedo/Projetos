using System;
namespace MyCrud {
    class Produto {
        public int Id;//identificador = Codigo Produto
        public string Nome;
        public double Preco;
    }
    class Program {
        static List<Produto> listaDProduto = new List<Produto>();
        static int CodProduto = 1;
        
        
        static void Criar() {
            Console.WriteLine("\t\t\t=== (Cadastrar Produto) ===");
            Console.Write("Nome: ");
            string nome = Convert.ToString(Console.ReadLine());
            Console.Write("Preço: ");
            double preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cadastro Realizado com Sucesso!");

            //adicionar produto e preço e seta id na lista de produtos
            listaDProduto.Add(new Produto {
                Id = CodProduto++,
                Nome = nome,
                Preco = preco
            });
            ExibirMenu();
        }
        static void Mostrar() {
            Console.WriteLine("\t\t\t=== (Produtos Cadastrados) ===");
            Console.WriteLine("ID | Nome | Preço");
            foreach (var i in listaDProduto) {
                Console.WriteLine($"{i.Id} | {i.Nome} | {i.Preco}");
            }
            ExibirMenu();
        }
        static void Atualizar() {
            Console.WriteLine("\t\t\t=== (Atualizando Cadastro) ===");
            Console.Write("ID do produto para atualizar:");
            int id = Convert.ToInt32(Console.ReadLine());
            var produto = listaDProduto.FirstOrDefault(p => p.Id == id);
            if (id != null) {
                Console.Write("Novo Nome Do Produto:");
                produto.Nome = Console.ReadLine();
                Console.Write("Novo Preço Do Produto:");
                produto.Preco = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Produto Atualizado com Sucesso!");
                
            }
            else {
                Console.WriteLine("Produto Não Encontrado....");
            }
            ExibirMenu();
        }
        static void Excluir() {
            Console.WriteLine("\t\t\t=== (Excluir Produto) ===");
            Console.Write("ID do produto para Excluir:");
            int id = Convert.ToInt32(Console.ReadLine());
            var produto = listaDProduto.FirstOrDefault(p => p.Id == id);
            if (id != null) {
                listaDProduto.Remove(produto);
                Console.WriteLine("Produto Excluido Com Sucesso!");
            }
            else {
                Console.WriteLine("Produto Não Encontrado...");
            }
            ExibirMenu();
        }
        static void ExibirMenu() {
            Console.WriteLine("\t\t\t=== (CRUD No Console) ===");
            Console.WriteLine("\nSelecione uma Opção");
            Console.WriteLine("Criar Opção:1");
            Console.WriteLine("Mostrar Opção:2");
            Console.WriteLine("Atualizar Opção:3");
            Console.WriteLine("Excluir Opção:4");
            Console.WriteLine("Sair Opção:5");
            Console.Write("Opção Selecionada:");
        }
        public static void Main() {
            ExibirMenu();
            //estava causando erro no codigo deixa ele ai pq perdi muito tempo 
            //para encontralo kkkkk
            //string opcao = Convert.ToString(Console.ReadLine());
            while (true) {
                //string  continuar = Convert.ToString(Console.ReadLine().ToUpper());
                switch (Console.ReadLine()) {
                    case "1": Criar();break;
                    case "2": Mostrar(); break;
                    case "3": Atualizar(); break;
                    case "4": Excluir(); break;
                    case "5": return;
                    default:
                        Console.WriteLine("Opção Invalida...\nTENTE NOVAMENTE.!");
                        ExibirMenu();
                        break;
                }
                //Console.WriteLine("Deseja Continuar(True/False)");
                //continuar = Convert.ToBoolean(Console.ReadLine());
                //Console.Clear();
                //ExibirMenu();
            }
        }
    }
}