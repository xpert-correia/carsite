using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Modelos
/// </summary>
/// 
namespace Modelos
{
    public class Pessoas //_nome, _apelido, _email, _morada, _localidade, _codpostal, _password, _telefone, _username, _nif, _nib, _iban, _datanascimento, _datainscricao;
    {
        string _nome, _apelido, _email, _morada, _localidade, _codpostal, _password, _telefone, _username, _datanascimento;
        long _nif, _nib, _iban;
        DateTime _datainscricao;
        Boolean _aprovado;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Apelido
        {
            get { return _apelido; }
            set { _apelido = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Morada
        {
            get { return _morada; }
            set { _morada = value; }
        }
        public string Localidade
        {
            get { return _localidade; }
            set { _localidade = value; }
        }
        public string Codpostal
        {
            get { return _codpostal; }
            set { _codpostal = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public long Nif
        {
            get { return _nif; }
            set { _nif = value; }
        }
        public long Nib
        {
            get { return _nib; }
            set { _nib = value; }
        }
        public long Iban
        {
            get { return _iban; }
            set { _iban = value; }
        }
        public string Datanascimento
        {
            get { return _datanascimento; }
            set { _datanascimento = value; }
        }
        public DateTime Datainscricao
        {
            get { return _datainscricao; }
            set { _datainscricao = value; }
        }
        public Boolean Aprovado
        {
            get { return _aprovado; }
            set { _aprovado = value; }
        }
    }
    public class automovel //_marca;_modelo;_segmento;_matricula;_preço;_kilometragem, _carroid, _donoid;_datafabrico;_datainserção;_dataremoção; 
    {
        string _marca, _modelo, _segmento, _matricula, _localidade;
        int _preço;
        long _kilometragem, _carroid, _donoid;
        DateTime _datafabrico, _datainserção, _dataremoção;

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public string Segmento
        {
            get { return _segmento; }
            set { _segmento = value; }
        }
        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }
        public int Preço
        {
            get { return _preço; }
            set { _preço = value; }
        }
        public long Kilometragem
        {
            get { return _kilometragem; }
            set { _kilometragem = value; }
        }
        public long Carroid
        {
            get { return _carroid; }
            set { _carroid = value; }
        }
        public long Donoid
        {
            get { return _donoid; }
            set { _donoid = value; }
        }
        public DateTime Datafabrico
        {
            get { return _datafabrico; }
            set { _datafabrico = value; }
        }
        public DateTime Datainserção
        {
            get { return _datainserção; }
            set { _datainserção = value; }
        }
        public DateTime Dataremoção
        {
            get { return _dataremoção; }
            set { _dataremoção = value; }
        }
        public string Localidade
        {
            get { return _localidade; }
            set { _localidade = value; }
        }
 
    }
    public class Mensagem
    {
        DateTime _datacomentario;
        long _carroid, _interessadoid;
        string _corpodamensagem;
        bool _fornecercontactotelefonico;

        public bool Fornecercontactotelefonico
        {
            get { return _fornecercontactotelefonico; }
            set { _fornecercontactotelefonico = value; }
        }

        public string Corpodamensagem
        {
            get { return _corpodamensagem; }
            set { _corpodamensagem = value; }
        }
        public DateTime Datacomentario
        {
            get { return _datacomentario; }
            set { _datacomentario = value; }
        }
        public long Carroid
        {
            get { return _carroid; }
            set { _carroid = value; }
        }
        public long Interessadoid
        {
            get { return _interessadoid; }
            set { _interessadoid = value; }
        }
    }
    public class Empregado : Pessoas
    {
        Boolean _admin, _posts;
        DateTime _datainiciocontrato, _datafimcontrato;
        decimal _salario, _bonus, _vendasbruto;

        public Boolean admin
        {
            get { return _admin; }
            set { _admin = value; }
        }
        public Boolean posts
        {
            get { return _posts; }
            set { _posts = value; }
        }
        public DateTime datainiciocontrato
        {
            get { return datainiciocontrato; }
            set { datainiciocontrato = value; }
        }
        public DateTime datafimcontrato
        {
            get { return _datafimcontrato; }
            set { _datafimcontrato = value; }
        }
        public decimal salario
        {
            get { return _salario; }
            set { _salario = value; }
        }
        public decimal bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }
        public decimal vendasbruto
        {
            get { return _vendasbruto; }
            set { _vendasbruto = value; }
        }
    }
}
