using System;

namespace ProjEstudoOB {
    internal class Pessoa {

        private String nome;
        private String dataNasc;
        private int cpf;
        private int telefone;

         public Pessoa(String nome, String dataNasc, int cpf, int telefone) {
            this.nome = nome;
            this.dataNasc = dataNasc;
            this.cpf = cpf;
            this.telefone = telefone;
        }

        public Pessoa() { }

        public void  getNome(String nome) {
            this.nome = nome;
        }

        public String setNome(String nome) {
            return nome;
        }
        
        public void getDateTime(String dataNasc) {
            this.dataNasc = dataNasc;
        }

        public String setDatanasc(String dataNasc) {
            return dataNasc;
        }

        public void getCpf(int cpf) {
            this.cpf = cpf;
        }

        public int setCpf(int cpf) {
           return cpf;
        }

        public void getTelefone(int telefone) {
            this.telefone = telefone;         
        }

        public int setTelefone(int telefone) {
            return telefone;
        }

        public override String ToString() {
            return "\t\n*** Cadastro *** \n"+
                   "\nNome: "+nome+
                   "\nData de Nascimento: "+dataNasc+
                   "\nCPF: "+cpf+
                   "\nTelefone: " + telefone;
        }
    }
}
