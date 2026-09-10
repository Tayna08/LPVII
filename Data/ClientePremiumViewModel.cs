using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
  
    public class ClientePremiumViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MinLength(5, ErrorMessage = "O campo {0} deve ter no mínimo {1} caracteres.")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DataType(DataType.Date, ErrorMessage = "O campo {0} deve conter apenas uma data válida.")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$",
            ErrorMessage = "O campo {0} deve estar no formato 000.000.000-00.")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Phone(ErrorMessage = "O campo {0} não corresponde a um número de telefone válido.")]
        [Display(Name = "Telefone Celular")]
        public string TelefoneCelular { get; set; }

        // Opcional: sem [Required]. Se preenchido, deve ser uma URL válida.
        [Url(ErrorMessage = "O campo {0} deve conter uma URL válida (ex: https://www.linkedin.com/in/seu-perfil).")]
        [Display(Name = "URL do Perfil no LinkedIn")]
        public string UrlPerfilLinkedIn { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Range(typeof(decimal), "3000.00", "1000000.00",
            ErrorMessage = "O campo {0} deve estar entre {1} e {2}.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Renda Mensal")]
        public decimal RendaMensal { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [CreditCard(ErrorMessage = "O campo {0} não corresponde a um número de cartão de crédito válido.")]
        [Display(Name = "Número do Cartão de Crédito")]
        public string NumeroCartaoCredito { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).{8,}$",
            ErrorMessage = "O campo {0} deve ter no mínimo 8 caracteres, contendo ao menos uma letra maiúscula, uma minúscula, um número e um caractere especial.")]
        [Display(Name = "Senha de Acesso")]
        public string SenhaAcesso { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DataType(DataType.Password)]
        [Compare(nameof(SenhaAcesso), ErrorMessage = "As senhas informadas não coincidem.")]
        [Display(Name = "Confirmar Senha de Acesso")]
        public string ConfirmarSenhaAcesso { get; set; }
    }
}
