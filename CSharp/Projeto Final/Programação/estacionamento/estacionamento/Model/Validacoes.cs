using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Estacionamento.Control;
using Estacionamento.Model;

namespace Estacionamento.Model
{
    class Validacoes
    {
        Usuario usu = new Usuario();

        GerenciarAdministrador gerAdm = new GerenciarAdministrador();
        GerenciarCliente gerCli = new GerenciarCliente();
        GerenciarVeiculo gerVei = new GerenciarVeiculo();

        //Campos do cliente que devem ser preenchidos obrigatoriamente.
        public string validarCamposCadastroCliente(string tipoCliente, string nome, string login)
        {
            string validacaoCliente = "";

            if (tipoCliente.Trim() == "")
                validacaoCliente += "O campo Tipo de Cliente deve ser preenchido! \n";
            if (nome.Trim() == "")
                validacaoCliente += "O nome do cliente deve ser preenchido! \n";
            if (login.Trim().Length < 7)
                validacaoCliente += "O campo login deve ser preenchido, e deve conter 7 dígitos (3 letras e 4 números)! \n";
            if (!verificarLoginDigitadoCliente(login))
                validacaoCliente += "O login digitado já existe. Por favor, digite outro! \n";

            return validacaoCliente;
        }

        //Campos do veículo que devem ser preenchidos obrigatoriamente.
        public string validarCamposCadastroVeiculo(string tipoPlano, string placa)
        {
            string validacaoVeiculo = "";

            if (tipoPlano.Trim() == "")
                validacaoVeiculo += "O campo Tipo de Plano deve ser preenchido! \n";
            if (placa.Trim() == "-" || placa.Trim().Length < 8)
                validacaoVeiculo += "A placa do veículo deve ser digitada, e deve conter 7 dígitos! \n";
            if (!verificarPlacaDigitada(placa))
            {
                if (MessageBox.Show("A placa digitada já foi cadastrada pelo cliente " + gerCli.retornarNomeClientePorId(gerVei.retornarIdClientePorPlaca(placa))
                    + ".\nGostaria de excluir esse registro de veículo?", "Excluir placa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (gerVei.apagarVeiculo(placa))
                        MessageBox.Show("Dados excluídos com sucesso!");
                    else
                        MessageBox.Show("Houve algum erro interno, tente novamente!");
                }
                else
                    validacaoVeiculo += "A placa digitada já existe. Por favor, digite outra! \n";
            }

            return validacaoVeiculo;
        }

        //Campos do administrador que devem ser preenchidos obrigatoriamente.
        public string validarCamposCadastroAdministrador(string nome, string login, string senha, string confirmaSenha)
        {
            string validacaoAdministrador = "";

            if (nome.Trim() == "")
            {
                validacaoAdministrador += "O campo Nome deve ser preenchido! \n";
            }
            if (!preencherLoginSenha(login, senha))
            {
                validacaoAdministrador += "O login e a senha devem ser preenchidos! \n";
            }
            if (!confirmarSenhaCadastro(senha, confirmaSenha))
            {
                validacaoAdministrador += "A senha digitada na confirmação é diferente da original! \n";
            }
            if (!verificarLoginDigitado(login))
            {
                validacaoAdministrador += "O login digitado já existe. Por favor, digite outro! \n";
            }
            return validacaoAdministrador;
        }

        //Campos do operador que devem ser preenchidos obrigatoriamente.
        public string validarCamposCadastroOperador(string nome, string login, string senha, string confirmaSenha)
        {
            string validacaoOperador = "";

            if (nome.Trim() == "")
            {
                validacaoOperador += "O campo Nome deve ser preenchido! \n";
            }
            if (!preencherLoginSenha(login, senha))
            {
                validacaoOperador += "O login e a senha devem ser preenchidos! \n";
            }
            if (!confirmarSenhaCadastro(senha, confirmaSenha))
            {
                validacaoOperador += "A senha digitada na confirmação é diferente da original! \n";
            }
            if (!verificarLoginDigitado(login))
            {
                validacaoOperador += "O login digitado já foi cadastrado. Por favor, digite outro! \n";
            }
            return validacaoOperador;
        }

        //Campos do operador que devem ser preenchidos obrigatoriamente.
        public string validarCamposCadastroDependente(string nomeTitular, string nome)
        {
            string validacaoDependente = "";

            if (nomeTitular.Trim() == "")
                validacaoDependente += "Um titular deve ser escolhido para que a operação seja executada! \n";

            if (nome.Trim() == "")
                validacaoDependente += "O campo Nome deve ser preenchido! \n";

            return validacaoDependente;
        }

        //Método que retorna apenas a descrição, sem o id, em um texto no formato id - descrição
        public string retornarTextoSemId(string texto)
        {
            int posId = texto.Trim().IndexOf("-");
            string textoId = texto.Trim().Substring(posId + 2);
            return textoId.Trim();
        }

        //Método que retorna apenas o id de um texto com uma descrição no formato id - descrição
        public string retornarIdSemTexto(string texto)
        {
            int posId = texto.IndexOf("-");
            string idTexto = texto.Substring(0, posId);
            return idTexto.Trim();
        }

        //Verifica se o login e a senha foram preenchidos
        public bool preencherLoginSenha(string login, string senha)
        {
            if ((login.Trim() == "") || (senha.Trim() == ""))
                return false;
            else
                return true;
        }

        //Verifica se a senha digitada é a mesma da digitada na confirmação
        public bool confirmarSenhaCadastro(string senha1, string senha2)
        {
            if (senha1.Trim() == senha2.Trim())
                return true;
            else
                return false;
        }

        //Verifica se o login digitado já foi cadastrado
        public bool verificarLoginDigitado(string login)
        {
            if (gerAdm.consultarLoginAdministrador(login))
                return true;
            else
                return false;
        }

        //Verifica se o login digitado pelo cliente já foi cadastrado
        public bool verificarLoginDigitadoCliente(string login)
        {
            if (gerCli.consultarLoginCliente(login))
                return true;
            else
                return false;
        }

        //Verifica se a placa digitada já foi cadastrada e retorna true caso não conste
        public bool verificarPlacaDigitada(string placa)
        {
            if (gerVei.consultarPlaca(placa))
                return true;
            else
                return false;
        }
    }
}
