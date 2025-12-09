using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CadlunoTorloni.Models;

public partial class CadAlunoTorloniContext : DbContext
{
    public CadAlunoTorloniContext()
    {
    }

    public CadAlunoTorloniContext(DbContextOptions<CadAlunoTorloniContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aluno> Alunos { get; set; }

    public virtual DbSet<Frutum> Fruta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=NOTE04-S19\\SQLEXPRESS;User Id=sa; Password=Senai@134; Database=CadAlunoTorloni;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__aluno__3213E83FA1C86F0D");
        });

        modelBuilder.Entity<Frutum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__fruta__3213E83FB150F59B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
