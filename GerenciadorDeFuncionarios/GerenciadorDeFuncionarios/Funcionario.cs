using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeFuncionarios
{
    class Funcionario
    {
        public string   nome,
                        sobrenome,
                        sexo,
                        profissao,
                        estadoCivil,
                        telefone,
                        email,
                        endereco,
                        cep,
                        cpf,
                        dataC,
                        facebook;

        public int      id,
                        idade,
                        filhos;

        public float    salario;

        public override string ToString()
        {
            if (id != 0)
            {
                return "" + id + " " + nome + " " + sobrenome + " " + profissao + " " + idade + " anos";
            }
            else {
                return "Clique em [Adicionar] para adicionar um novo.";
            }
        }

        /*public Funcionario(string _nome, string _sobrenome, string _sexo, string _profissao, string _estadoCivil, string _tipoSanguineo, string _telefone, string _email, string _endereco, string _cep, string _cpf, string _dataC, string _facebook, int _idade, int _filhos)
        {
                nome = _nome;
                sobrenome =_sobrenome;
                sexo = _sexo;
                profissao = _profissao;
                estadoCivil = _estadoCivil;
                tipoSanguíneo = _tipoSanguineo;
                telefone = _telefone;
                email = _email;
                endereco = _endereco;
                cep = _cep;
                cpf = _cpf;
                dataC = _dataC;
                facebook = _facebook;

                idade = _idade;
                filhos = _filhos;
        }*/
    }
}
