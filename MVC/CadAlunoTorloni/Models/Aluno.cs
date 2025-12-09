using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CadlunoTorloni.Models;

[Table("aluno")]
public partial class Aluno
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [Column("idade")]
    [StringLength(255)]
    [Unicode(false)]
    public string Idade { get; set; } = null!;
}
