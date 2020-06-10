namespace Aula13Uber
{
    public class Motorista : Usuario
    {

        public string Carro { get; set; }
        public string Placa { get; set; }


        public string aceitarPassageiro(string Nome, string aceitar){
            if(aceitar == "Voce aceitou a corrida"){

            return "efetuando corrida";
            
                }return "Corrida negada";
        }


    }
}