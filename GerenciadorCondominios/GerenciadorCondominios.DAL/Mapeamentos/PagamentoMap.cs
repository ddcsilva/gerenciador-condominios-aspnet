using GerenciadorCondominios.BLL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorCondominios.DAL
{
    public class PagamentoMap : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.HasKey(p => p.PagamentoId);
            builder.Property(p => p.DataPagamento).IsRequired();
            builder.Property(p => p.Status).IsRequired();
            builder.HasOne(p => p.Usuario).WithMany(p => p.Pagamentos).HasForeignKey(p => p.UsuarioId).IsRequired();
            builder.HasOne(p => p.Aluguel).WithMany(p => p.Pagamentos).HasForeignKey(p => p.AluguelId).IsRequired();
            builder.ToTable("Pagamentos");
        }
    }
}
