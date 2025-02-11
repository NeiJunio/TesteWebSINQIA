using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteWebSINQIA.Models
{
    // TEstrutura da Tabela
    public class PontosTuristicosModel
    {
        public int Id { get; set; }

        [Required] // Campo Obrigatório
        [StringLength(100)] // Tamanho máximo de 100 caracteres
        public string Nome { get; set; } = string.Empty;
        
        [Required] 
        [StringLength(100)]
        public string  Descricao { get; set; } = string.Empty;
        
        [Required] 
        [StringLength(100)] 
        public string  Endereco { get; set; } = string.Empty;
        
        [StringLength(100)]
        public string  Referencia { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)] // Tamanho máximo de 50 caracteres
        public string  Cidade { get; set; } = string.Empty;
        
        [Required]
        [StringLength(2)] // Tamanho máximo de 2 caracteres (Armazanará apenas as siglas. Ex: SP, RJ, MG...)
        public string  Estado { get; set; } = string.Empty;

        [Required]
        public DateTime DataCriacao {get; set;} = DateTime.Now; // captura automaticamente a data e hora da criação do registro
    }
}