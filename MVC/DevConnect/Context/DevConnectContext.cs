using DevConnect.Models;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Context;

public partial class DevConnectContext : DbContext
{
    public DevConnectContext()
    {
    }

    public DevConnectContext(DbContextOptions<DevConnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbComentario> TbComentario { get; set; }

    public virtual DbSet<TbCurtida> TbCurtida { get; set; }

    public virtual DbSet<TbPublicacao> TbPublicacao { get; set; }

    public virtual DbSet<TbUsuario> TbUsuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DevCon_SA");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbComentario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_comen__3213E83FFD88DC38");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TbComentario).HasConstraintName("FK__tb_coment__id_pu__6477ECF3");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbComentario).HasConstraintName("FK__tb_coment__id_us__6383C8BA");
        });

        modelBuilder.Entity<TbCurtida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_curti__3213E83F6878AE6C");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TbCurtida).HasConstraintName("FK__tb_curtid__id_pu__68487DD7");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbCurtida).HasConstraintName("FK__tb_curtid__id_us__6754599E");
        });

        modelBuilder.Entity<TbPublicacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_publi__3213E83F8813EE72");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbPublicacao).HasConstraintName("FK__tb_public__id_us__60A75C0F");
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_usuar__3213E83FBE4A4FC0");

            entity.HasMany(d => d.IdUsuarioSeguida).WithMany(p => p.IdUsuarioSeguir)
                .UsingEntity<Dictionary<string, object>>(
                    "TbSeguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguida")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__04E4BC85"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguir")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__03F0984C"),
                    j =>
                    {
                        j.HasKey("IdUsuarioSeguir", "IdUsuarioSeguida").HasName("PK__tb_segui__CFA87AC03948265D");
                        j.ToTable("tb_seguidor");
                        j.IndexerProperty<int>("IdUsuarioSeguir").HasColumnName("id_usuario_seguir");
                        j.IndexerProperty<int>("IdUsuarioSeguida").HasColumnName("id_usuario_seguida");
                    });

            entity.HasMany(d => d.IdUsuarioSeguir).WithMany(p => p.IdUsuarioSeguida)
                .UsingEntity<Dictionary<string, object>>(
                    "TbSeguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguir")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__03F0984C"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguida")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__04E4BC85"),
                    j =>
                    {
                        j.HasKey("IdUsuarioSeguir", "IdUsuarioSeguida").HasName("PK__tb_segui__CFA87AC03948265D");
                        j.ToTable("tb_seguidor");
                        j.IndexerProperty<int>("IdUsuarioSeguir").HasColumnName("id_usuario_seguir");
                        j.IndexerProperty<int>("IdUsuarioSeguida").HasColumnName("id_usuario_seguida");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
