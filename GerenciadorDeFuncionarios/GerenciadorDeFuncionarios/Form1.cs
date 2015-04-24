using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeFuncionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Funcionario> listaDefault = new List<Funcionario>();

        public string listAtual;

        private string sexoAtual;

        private int idAtual = 1;

        public bool contemLetras(string texto)
        {
            if (texto.Where(c => char.IsLetter(c)).Count() > 0)
                return true;
            else
                return false;
        }

        Funcionario fDefault = new Funcionario();



        private void Form1_Load(object sender, EventArgs e)
        {
            listFuncionarios.Items.Add(fDefault);
            printText.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Funcionario f1 = new Funcionario();
            f1.nome = enterNome.Text;
            f1.sobrenome = enterSobrenome.Text;
            f1.estadoCivil = enterCivil.SelectedItem + "";
            f1.telefone = enterTelefone.Text;
            f1.email = enterEmail.Text;
            f1.endereco = enterEndereco.Text;
            f1.cep = enterCEP.Text;
            f1.cpf = enterCPF.Text;
            f1.dataC = enterDataCont.Text;
            f1.facebook = enterFacebook.Text;
            f1.profissao = enterProfissao.Text;
            f1.idade = int.Parse(enterIade.Value + "");
            f1.filhos = int.Parse(enterFilhos.Value + "");
            f1.salario = float.Parse(enterSalario.Text);
            f1.sexo = sexoAtual;
            f1.id = idAtual;

           if(contemLetras(enterSalario.Text)){
               f1.salario = 0;
            }

            listaDefault.Add(f1);
            listFuncionarios.Items.RemoveAt(idAtual - 1);

            listFuncionarios.Items.Add(f1);

            listFuncionarios.Items.Add(fDefault);

            enterFeminino.Checked = false;
            enterMasculino.Checked = false;

            sexoAtual = null;
            idAtual++;
            printText.Text += "ID: "  +  f1.id  +  "|Nome:" + f1.nome + "|Soberenome:" + f1.sobrenome + "|Profissão:" + f1.profissao + "|Sexo:" + f1.sexo + "|EstadoCivil:" + f1.estadoCivil + "|Telefone:" + f1.telefone + "|email"+f1.email+"|Endereço:"+f1.endereco+"|CEP:"+f1.cep+"|CPF:"+f1.cpf+"|Data de Contratação:"+f1.dataC+"|Facebook:"+f1.facebook+"|Idade:"+f1.idade+"|Número de Filhos:"+f1.filhos+"|Salário:"+f1.salario+"|\n";
        }

        private void print2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + listaDefault[1].nome);
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + listaDefault.Count);
        }

        private void listFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listFuncionarios.SelectedItem != null)
            {
                if (listFuncionarios.SelectedItem.ToString() != "Clique em [Adicionar] para adicionar um novo.")
                {
                    //MessageBox.Show(listFuncionarios.SelectedItem.ToString());
                }
            }
        }

        private void enterMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if(enterMasculino.Checked){
                if(enterFeminino.Checked){
                    enterFeminino.Checked = false;
                }
                sexoAtual = "Masculino";
            }
        }

        private void enterFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (enterFeminino.Checked)
            {
                if (enterMasculino.Checked)
                {
                    enterMasculino.Checked = false;
                }
                sexoAtual = "Feminino";
            }
        }

        private void excButton_Click(object sender, EventArgs e)
        {
            if (listFuncionarios.SelectedItem.ToString() != "Clique em [Adicionar] para adicionar um novo.")
            {
                int i = listFuncionarios.SelectedIndex;
                listaDefault.RemoveAt(i);
                listFuncionarios.Items.RemoveAt(i);
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (listFuncionarios.SelectedIndex > -1) {
                listaDefault[listFuncionarios.SelectedIndex].nome = enterNome.Text;
                listaDefault[listFuncionarios.SelectedIndex].sobrenome = enterSobrenome.Text;
                listaDefault[listFuncionarios.SelectedIndex].estadoCivil = enterCivil.SelectedItem + "";
                listaDefault[listFuncionarios.SelectedIndex].telefone = enterTelefone.Text;
                listaDefault[listFuncionarios.SelectedIndex].email = enterEmail.Text;
                listaDefault[listFuncionarios.SelectedIndex].endereco = enterEndereco.Text;
                listaDefault[listFuncionarios.SelectedIndex].cep = enterCEP.Text;
                listaDefault[listFuncionarios.SelectedIndex].cpf = enterCPF.Text;
                listaDefault[listFuncionarios.SelectedIndex].dataC = enterDataCont.Text;
                listaDefault[listFuncionarios.SelectedIndex].facebook = enterFacebook.Text;
                listaDefault[listFuncionarios.SelectedIndex].profissao = enterProfissao.Text;
                listaDefault[listFuncionarios.SelectedIndex].idade = int.Parse(enterIade.Value + "");
                listaDefault[listFuncionarios.SelectedIndex].filhos = int.Parse(enterFilhos.Value + "");
                listaDefault[listFuncionarios.SelectedIndex].salario = float.Parse(enterSalario.Text);
                listaDefault[listFuncionarios.SelectedIndex].sexo = sexoAtual;

                if (contemLetras(enterSalario.Text))
                {
                    listaDefault[listFuncionarios.SelectedIndex].salario = 0;
                }

                listFuncionarios.Items.Clear();

                printText.Text = "";

                for (int i = 0; i < listaDefault.Count; i++ ) {
                    listFuncionarios.Items.Add(listaDefault[i]);

                    printText.Text += "ID: " + listaDefault[i].id + "|Nome:" + listaDefault[i].nome + "|Soberenome:" + listaDefault[i].sobrenome + "|Profissão:" + listaDefault[i].profissao + "|Sexo:" + listaDefault[i].sexo + "|EstadoCivil:" + listaDefault[i].estadoCivil + "|Telefone:" + listaDefault[i].telefone + "|E-mail:" + listaDefault[i].email + "|Endereço:" + listaDefault[i].endereco + "|CEP:" + listaDefault[i].cep + "|CPF:" + listaDefault[i].cpf + "|Data de Contratação:" + listaDefault[i].dataC + "|Facebook:" + listaDefault[i].facebook + "|Idade:" + listaDefault[i].idade + "|Número de Filhos:" + listaDefault[i].filhos + "|Salário:" + listaDefault[i].salario + "\n";
                }

                listFuncionarios.Items.Add(fDefault);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"WriteText.txt", printText.Text);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string[] linhas = System.IO.File.ReadAllLines(@"WriteText.txt");
            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(new Char[] { '|', ':' });
                Funcionario func = new Funcionario()
                {
                    id = int.Parse(dados[2]),
                    nome = dados[4],
                    sobrenome = dados[6],
                    estadoCivil = dados[12],
                    telefone = dados[14],
                    email = dados[16],
                    endereco = dados[18],
                    cep = dados[20],
                    cpf = dados[22],
                    dataC = dados[24],
                    facebook = dados[26],
                    profissao = dados[8],
                    idade = int.Parse(dados[28]),
                    filhos = int.Parse(dados[30]),
                    salario = float.Parse(dados[32]),
                    sexo = dados[10],
                };
                //func.nome = dados[4];
                //...
                listaDefault.Add(func);
            }



            /*
            printText.Text = System.IO.File.ReadAllText(@"WriteText.txt");


            string[] split = printText.Text.Split(new Char[] { '|', ':' });
            /*for (int i = 0; i < split.Length; i++ )
            {
                MessageBox.Show(split[i]);
            }
            
            //List<Funcionario> listaDefault = new List<Funcionario>();

            listFuncionarios.Items.Clear();

            for (int a = 0; a < split.Length / 32; a++)
            {
                Funcionario f1 = new Funcionario();
                for (int i = 0; i < split.Length; i++)
                {
                    f1.id = int.Parse(split[2]);
                    f1.nome = split[4];
                    f1.sobrenome = split[6];
                    f1.estadoCivil = split[12];
                    f1.telefone = split[14];
                    f1.email = split[16];
                    f1.endereco = split[18];
                    f1.cep = split[20];
                    f1.cpf = split[22];
                    f1.dataC = split[24];
                    f1.facebook = split[26];
                    f1.profissao = split[8];
                    f1.idade = int.Parse(split[28]);
                    f1.filhos = int.Parse(split[30]);
                    f1.salario = float.Parse(split[32]);
                    f1.sexo = split[10];
                }
                listaDefault.Add(f1);
            }
            for (int i = 0; i < listaDefault.Count; i++){
                listFuncionarios.Items.Add(listaDefault[i]);
            }*/
        }
        
    }
}
