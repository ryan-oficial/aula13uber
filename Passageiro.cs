namespace Aula13Uber
{
    public class Passageiro : Usuario
    {
        public string ProcurarMotorista(){
            return "Procurando motoristas disponiveis . . . ";
        }
        public string Pagar(string statusCorrida){
            if(statusCorrida == "Finalizada"){
                return "Pagamento efetuado";
            }
            return "Pagamento pendente";
        }
    }
}