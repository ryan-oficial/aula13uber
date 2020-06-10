namespace Aula13Uber
{
    public class Usuario
    {
        public string Nome { get; set; }
        private string login = "ryan";
        private string senha = "123";
        public string Foto { get; set; }
        public string LocalizaçaoAtual { get; set; }
        public string TokenLogin { get; set; }
        public bool Passageiro { get; set; }
        public bool Motorista { get; set; }
        


        public bool Login(string login, string senha){

                 if(this.login == login && this.senha == senha){
                TokenLogin = "agwsyhewre4htryh11e65sr4j854sret";

                return true;
                 }
            return false;
            }
            public void Logout(){
                TokenLogin = "";  
        }
    }
}