namespace GestãoEquipamentos.ConsoleApp
{
    /*Requisito 1.1: Como funcionário, Junior quer ter a possibilidade de registrar equipamentos  

         •  Deve ter um nome com no mínimo 6 caracteres;  
         •  Deve ter um preço de aquisição;  
         •  Deve ter um número de série;  
         •  Deve ter uma data de fabricação;  
         •  Deve ter uma fabricante;   

      Requisito 1.2: Como funcionário, Junior quer ter a possibilidade de visualizar todos os equipamentos registrados em seu inventário.  

         •  Deve mostrar o número;  
         •  Deve mostrar o nome;  
         •  Deve mostrar o preço; 
         •  Deve mostrar a fabricante;   
         •  Deve mostrar a data de fabricação;   

      Requisito 1.3:  Como funcionário, Junior quer ter a possibilidade de editar um equipamento, sendo que ele possa
editar todos os campos.   

         •  Deve ter os mesmos critérios que o Requisito 1.
 
      Requisito 1.4: Como funcionário, Junior quer ter a possibilidade de excluir um equipamento que esteja registrado. 
 
         •  A lista de equipamentos deve ser atualizada */
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario junior = new Funcionario("Junior", 1000.0, 123456, "01-01-2024", "Empresa XYZ");
            Equipamento pa = new Equipamento(001, "pá", 30.00, "Fabricante", "15-04-2024");
        }
    }
    public class Funcionario
    {
        public string nome;
        public double precoAquisicao;
        public int NSerie;
        public string dataFabricacao;
        public string fabricante;

        private List<Equipamento> equipamentos = new List<Equipamento>();

        public Funcionario(string nome, double precoAquisicao, int nSerie, string dataFabricacao, string fabricante)
        {
            this.nome = nome;
            this.precoAquisicao = precoAquisicao;
            NSerie = nSerie;
            this.dataFabricacao = dataFabricacao;
            this.fabricante = fabricante;
        }

        public Equipamento RegistrarEquipamento(int numero, string nome, double preco, string fabricante, string dataFabricacao)
        {
            Equipamento equipamento = new Equipamento(numero, nome, preco, fabricante, dataFabricacao);
            equipamentos.Add(equipamento);
            return equipamento;
        }

        public void VisualizarEquipamentos()
        {
            foreach (var equipamento in equipamentos)
            {
                Console.WriteLine($"Número: {equipamento.numero}");
                Console.WriteLine($"Nome: {equipamento.nome}");
                Console.WriteLine($"Preço: {equipamento.preco}");
                Console.WriteLine($"Fabricante: {equipamento.fabricante}");
                Console.WriteLine($"Data de Fabricação: {equipamento.dataFabricacao}");
                Console.WriteLine($"Data de Fabricação: {equipamento.dataFabricacao}");
                Console.WriteLine();
            }
        }
        public bool ExcluirEquipamento(int numero, string nome, double preco, string fabricante, string dataFabricacao)
        {
            Equipamento equipamento = new Equipamento(numero, nome, preco, fabricante, dataFabricacao);

            if (equipamento != null)
            {
                equipamentos.Remove(equipamento);
                return true; 
            }
            else
            {
                Console.WriteLine("Equipamento não encontrado.");
                return false; 
            }
        }

    }
    public class Equipamento
    {
        public int numero;
        public string nome;
        public double preco;
        public string fabricante;
        public string dataFabricacao;

        public Equipamento(int numero, string nome, double preco, string fabricante, string dataFabricacao)
        {
            this.numero = numero;
            this.nome = nome;
            this.preco = preco;
            this.fabricante = fabricante;
            this.dataFabricacao = dataFabricacao;
        }
    }
}
