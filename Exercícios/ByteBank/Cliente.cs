using System;

namespace ByteBank
{
    public class Cliente
    {
        private string _Nome;
        private string _Cpf;
        private string _Email;
        private string _Senha;

        public string Senha
        {
            get {return _Senha; }
        }

        public string Cpf
        {
            get { return _Cpf; }
            set { _Cpf = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        /*Construtores */
        public Cliente(string nome,string cpf,string email){
            this._Nome = nome;
            this._Cpf = cpf;
            this._Email = email;
        }

        /*Método de acesso */
        public bool TrocaSenha(string senha){
            if ((senha.Length > 6) && (senha.Length < 16)){
                this._Senha = senha;
                return true;
            }else {
                return false;
            }
        }
    }
}