using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Trabalho_Rogerio.Models
{
    public class Contas
    {
        [Key]

        [DisplayName("Id")]
        public int ContasId { get; set; }

        [DisplayName("Fornecedor")]
        [MaxLength(50, ErrorMessage = "O campo não pode ser ultrapassar {0} caracteres")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "O campo Data de Venciemnto é de preenchimento obrigatório !")]
        [DisplayName("Data do Vencimento")]
        [DataType(DataType.Date)]
        public DateTime Dtvencimento { get; set; }

        [Required(ErrorMessage = "O campo Data de Pagamento é de preenchimento obrigatório !")]
        [DisplayName("Data de Pagamento")]
        [DataType(DataType.Date)]
        public DateTime Dtpagamento { get; set; }

        public bool Pago { get; set; }
        
        [DisplayName("Descrição")]
        [MaxLength(100, ErrorMessage = "O campo não pode ser ultrapassar {0} caracteres")]
        public string Descricao { get; set; }

        [DisplayName("Valor")]
        public decimal Valor { get; set; }


    }
}