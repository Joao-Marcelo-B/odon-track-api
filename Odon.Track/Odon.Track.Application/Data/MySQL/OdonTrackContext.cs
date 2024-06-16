using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Data.MySQL.Entity;

namespace Odon.Track.Application.Data.MySQL;

public partial class OdontrackContext : DbContext
{
    public OdontrackContext(DbContextOptions<OdontrackContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CondutaProntoAtendimento> CondutaProntoAtendimentos { get; set; }

    public virtual DbSet<Disciplina> Disciplinas { get; set; }

    public virtual DbSet<Endereco> Enderecos { get; set; }
    public virtual DbSet<EnderecoResponsavel> EnderecosResponsavel { get; set; }

    public virtual DbSet<Estudante> Estudantes { get; set; }

    public virtual DbSet<NecessidadeTratamento> NecessidadeTratamentos { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<PacienteEstudante> PacienteEstudantes { get; set; }

    public virtual DbSet<PacienteStatus> PacienteStatuses { get; set; }

    public virtual DbSet<Professor> Professors { get; set; }

    public virtual DbSet<Prontuario> Prontuarios { get; set; }

    public virtual DbSet<ProntuarioEstudante> ProntuarioEstudantes { get; set; }

    public virtual DbSet<ProntuarioPmEstudante> ProntuarioPmEstudantes { get; set; }

    public virtual DbSet<ProntuarioProntoAtendimento> ProntuarioProntoAtendimentos { get; set; }

    public virtual DbSet<ProntuarioStatus> ProntuarioStatuses { get; set; }

    public virtual DbSet<ReavaliacaoAnamnese> ReavaliacaoAnamneses { get; set; }

    public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }

    public virtual DbSet<Triagem> Triagens { get; set; }
    public virtual DbSet<HorarioDisponivelAtendimento> HorariosDisponiveisAtendimento { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }
    public virtual DbSet<RolesSemestre> RolesSemestre { get; set; }
    public virtual DbSet<Roles> Roles { get; set; }
    public virtual DbSet<CodigoSeguranca> CodigoSeguranca { get; set; }
    public virtual DbSet<Responsavel> Responsaveis { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<DisciplinasProfessor>()
            .HasKey(dp => new { dp.Id_Disciplinas, dp.Id_Professor });

        modelBuilder.Entity<DisciplinasProfessor>()
            .HasOne(dp => dp.Disciplina)
            .WithMany(d => d.DisciplinasProfessores)
            .HasForeignKey(dp => dp.Id_Disciplinas);

        modelBuilder.Entity<DisciplinasProfessor>()
            .HasOne(dp => dp.Professor)
            .WithMany(p => p.DisciplinasProfessores)
            .HasForeignKey(dp => dp.Id_Professor);
    }



    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseMySQL("server=localhost;uid=root;pwd=Jp28072002;database=odontrack");

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<CondutaProntoAtendimento>(entity =>
    //        {
    //            entity.HasKey(e => new { e.Id, e.IdProntuarioProntoAtendimento }).HasName("PRIMARY");

    //            entity.ToTable("conduta_pronto_atendimento");

    //            entity.HasIndex(e => e.IdProntuarioProntoAtendimento, "id_prontuario_pronto_atendimento");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.IdProntuarioProntoAtendimento).HasColumnName("id_prontuario_pronto_atendimento");
    //            entity.Property(e => e.CodSus)
    //                .HasMaxLength(45)
    //                .HasColumnName("cod_sus");
    //            entity.Property(e => e.Conduta)
    //                .HasMaxLength(200)
    //                .HasColumnName("conduta");

    //            entity.HasOne(d => d.IdProntuarioProntoAtendimentoNavigation).WithMany(p => p.CondutaProntoAtendimentos)
    //                .HasForeignKey(d => d.IdProntuarioProntoAtendimento)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("conduta_pronto_atendimento_ibfk_1");
    //        });

    //        modelBuilder.Entity<Disciplina>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("disciplina");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.Nome)
    //                .HasMaxLength(50)
    //                .HasColumnName("nome");

    //            entity.HasMany(d => d.IdProfessors).WithMany(p => p.IdDisciplinas)
    //                .UsingEntity<Dictionary<string, object>>(
    //                    "DisciplinasProfessor",
    //                    r => r.HasOne<Professor>().WithMany()
    //                        .HasForeignKey("IdProfessor")
    //                        .OnDelete(DeleteBehavior.ClientSetNull)
    //                        .HasConstraintName("disciplinas_professor_ibfk_2"),
    //                    l => l.HasOne<Disciplina>().WithMany()
    //                        .HasForeignKey("IdDisciplinas")
    //                        .OnDelete(DeleteBehavior.ClientSetNull)
    //                        .HasConstraintName("disciplinas_professor_ibfk_1"),
    //                    j =>
    //                    {
    //                        j.HasKey("IdDisciplinas", "IdProfessor").HasName("PRIMARY");
    //                        j.ToTable("disciplinas_professor");
    //                        j.HasIndex(new[] { "IdProfessor" }, "id_professor");
    //                    });
    //        });

    //        modelBuilder.Entity<Endereco>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("endereco");

    //            entity.HasIndex(e => e.IdPaciente, "id_paciente");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.Bairro)
    //                .HasMaxLength(50)
    //                .HasColumnName("bairro");
    //            entity.Property(e => e.Cep)
    //                .HasMaxLength(10)
    //                .HasColumnName("cep");
    //            entity.Property(e => e.Cidade)
    //                .HasMaxLength(100)
    //                .HasColumnName("cidade");
    //            entity.Property(e => e.IdPaciente).HasColumnName("id_paciente");
    //            entity.Property(e => e.NumeroCasa)
    //                .HasMaxLength(10)
    //                .HasColumnName("numero_casa");
    //            entity.Property(e => e.Rua)
    //                .HasMaxLength(100)
    //                .HasColumnName("rua");
    //            entity.Property(e => e.Uf)
    //                .HasMaxLength(2)
    //                .HasColumnName("uf");

    //            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.Enderecos)
    //                .HasForeignKey(d => d.IdPaciente)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("endereco_ibfk_1");
    //        });

    //        modelBuilder.Entity<Estudante>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("estudante");

    //            entity.HasIndex(e => e.IdUsuario, "id_usuario");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
    //            entity.Property(e => e.Matricula)
    //                .HasMaxLength(15)
    //                .HasColumnName("matricula");
    //            entity.Property(e => e.Nome)
    //                .HasMaxLength(50)
    //                .HasColumnName("nome");

    //            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Estudantes)
    //                .HasForeignKey(d => d.IdUsuario)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("estudante_ibfk_1");
    //        });

    //        modelBuilder.Entity<HorarioDisponivelAtendimento>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("horario_disponivel_atendimento");

    //            entity.HasIndex(e => e.IdTriagem, "id_triagem");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.IdTriagem).HasColumnName("id_triagem");
    //            entity.Property(e => e.NoveMeia).HasColumnName("nove_meia");
    //            entity.Property(e => e.SeteMeia).HasColumnName("sete_meia");
    //            entity.Property(e => e.TresMeia).HasColumnName("tres_meia");
    //            entity.Property(e => e.UmaMeia).HasColumnName("uma_meia");

    //            entity.HasOne(d => d.IdTriagemNavigation).WithMany(p => p.HorarioDisponivelAtendimentos)
    //                .HasForeignKey(d => d.IdTriagem)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("horario_disponivel_atendimento_ibfk_1");
    //        });

    //        modelBuilder.Entity<NecessidadeTratamento>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("necessidade_tratamento");

    //            entity.HasIndex(e => e.IdTriagem, "id_triagem");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.Cirurgia)
    //                .HasMaxLength(400)
    //                .HasColumnName("cirurgia");
    //            entity.Property(e => e.Dentistica)
    //                .HasMaxLength(400)
    //                .HasColumnName("dentistica");
    //            entity.Property(e => e.Endodontia)
    //                .HasMaxLength(400)
    //                .HasColumnName("endodontia");
    //            entity.Property(e => e.IdTriagem).HasColumnName("id_triagem");
    //            entity.Property(e => e.Periodontia)
    //                .HasMaxLength(400)
    //                .HasColumnName("periodontia");
    //            entity.Property(e => e.Protese)
    //                .HasMaxLength(400)
    //                .HasColumnName("protese");

    //            entity.HasOne(d => d.IdTriagemNavigation).WithMany(p => p.NecessidadeTratamentos)
    //                .HasForeignKey(d => d.IdTriagem)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("necessidade_tratamento_ibfk_1");
    //        });

    //        modelBuilder.Entity<Paciente>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("paciente");

    //            entity.HasIndex(e => e.IdPacienteStatus, "id_paciente_status");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.CartaoNacionalSus)
    //                .HasMaxLength(45)
    //                .HasColumnName("cartao_nacional_sus");
    //            entity.Property(e => e.CartaoRegionalSus)
    //                .HasMaxLength(45)
    //                .HasColumnName("cartao_regional_sus");
    //            entity.Property(e => e.Cpf)
    //                .HasMaxLength(11)
    //                .HasColumnName("cpf");
    //            entity.Property(e => e.DataNascimento)
    //                .HasColumnType("date")
    //                .HasColumnName("data_nascimento");
    //            entity.Property(e => e.IdPacienteStatus).HasColumnName("id_paciente_status");
    //            entity.Property(e => e.IdTriagem).HasColumnName("id_triagem");
    //            entity.Property(e => e.Naturalidade)
    //                .HasMaxLength(45)
    //                .HasColumnName("naturalidade");
    //            entity.Property(e => e.NomeMae)
    //                .HasMaxLength(45)
    //                .HasColumnName("nome_mae");
    //            entity.Property(e => e.NomePai)
    //                .HasMaxLength(45)
    //                .HasColumnName("nome_pai");
    //            entity.Property(e => e.Profissao)
    //                .HasMaxLength(45)
    //                .HasColumnName("profissao");
    //            entity.Property(e => e.Rg)
    //                .HasMaxLength(15)
    //                .HasColumnName("rg");
    //            entity.Property(e => e.Telefone)
    //                .HasMaxLength(15)
    //                .HasColumnName("telefone");
    //            entity.Property(e => e.UfNaturalidade)
    //                .HasMaxLength(2)
    //                .HasColumnName("uf_naturalidade");

    //            entity.HasOne(d => d.IdPacienteStatusNavigation).WithMany(p => p.Pacientes)
    //                .HasForeignKey(d => d.IdPacienteStatus)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("paciente_ibfk_1");
    //        });

    //        modelBuilder.Entity<PacienteEstudante>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("paciente_estudante");

    //            entity.HasIndex(e => e.IdEstudante, "id_estudante");

    //            entity.HasIndex(e => e.IdPaciente, "id_paciente");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.IdEstudante).HasColumnName("id_estudante");
    //            entity.Property(e => e.IdPaciente).HasColumnName("id_paciente");

    //            entity.HasOne(d => d.IdEstudanteNavigation).WithMany(p => p.PacienteEstudantes)
    //                .HasForeignKey(d => d.IdEstudante)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("paciente_estudante_ibfk_1");

    //            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.PacienteEstudantes)
    //                .HasForeignKey(d => d.IdPaciente)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("paciente_estudante_ibfk_2");
    //        });

    //        modelBuilder.Entity<PacienteStatus>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("paciente_status");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.Descricao)
    //                .HasColumnType("enum('ativo','inativo')")
    //                .HasColumnName("descricao");
    //        });

    //        modelBuilder.Entity<Professor>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("professor");

    //            entity.HasIndex(e => e.IdUsuario, "id_usuario");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
    //            entity.Property(e => e.Nome)
    //                .HasMaxLength(100)
    //                .HasColumnName("nome");

    //            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Professors)
    //                .HasForeignKey(d => d.IdUsuario)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("professor_ibfk_1");
    //        });

    //        modelBuilder.Entity<Prontuario>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("prontuario");

    //            entity.HasIndex(e => e.IdPaciente, "id_paciente");

    //            entity.HasIndex(e => e.IdProfessorVinculado, "id_professor_vinculado");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.CaminhoMapaPeriodental)
    //                .HasMaxLength(150)
    //                .HasColumnName("caminho_mapa_periodental");
    //            entity.Property(e => e.DadosRelevantesHistoriaMedica)
    //                .HasMaxLength(300)
    //                .HasColumnName("dados_relevantes_historia_medica");
    //            entity.Property(e => e.DescricaoMedicamentoUsado)
    //                .HasMaxLength(700)
    //                .HasColumnName("descricao_medicamento_usado");
    //            entity.Property(e => e.FazUsoMedicamento).HasColumnName("faz_uso_medicamento");
    //            entity.Property(e => e.FezCirurgiasCardiacas).HasColumnName("fez_cirurgias_cardiacas");
    //            entity.Property(e => e.HabitoAlcool).HasColumnName("habito_alcool");
    //            entity.Property(e => e.HabitoAlcoolFrequencia)
    //                .HasMaxLength(150)
    //                .HasColumnName("habito__alcool_frequencia");
    //            entity.Property(e => e.HabitoAlcoolInicio)
    //                .HasColumnType("date")
    //                .HasColumnName("habito__alcool_inicio");
    //            entity.Property(e => e.HabitoFumo).HasColumnName("habito_fumo");
    //            entity.Property(e => e.HabitoFumoFrequencia)
    //                .HasMaxLength(150)
    //                .HasColumnName("habito_fumo_frequencia");
    //            entity.Property(e => e.HabitoFumoInicio)
    //                .HasColumnType("date")
    //                .HasColumnName("habito_fumo_inicio");
    //            entity.Property(e => e.HereditarioIrmaos)
    //                .HasMaxLength(150)
    //                .HasColumnName("hereditario_irmaos");
    //            entity.Property(e => e.HereditarioMae)
    //                .HasMaxLength(150)
    //                .HasColumnName("hereditario_mae");
    //            entity.Property(e => e.HereditarioPai)
    //                .HasMaxLength(150)
    //                .HasColumnName("hereditario_pai");
    //            entity.Property(e => e.HistoriaDoencaAtual)
    //                .HasMaxLength(600)
    //                .HasColumnName("historia_doenca_atual");
    //            entity.Property(e => e.IdPaciente).HasColumnName("id_paciente");
    //            entity.Property(e => e.IdProfessorVinculado).HasColumnName("id_professor_vinculado");
    //            entity.Property(e => e.Observacoes)
    //                .HasMaxLength(150)
    //                .HasColumnName("observacoes");
    //            entity.Property(e => e.OutrasAlergias)
    //                .HasMaxLength(400)
    //                .HasColumnName("outras_alergias");
    //            entity.Property(e => e.OutrasDoencaInfancia)
    //                .HasMaxLength(200)
    //                .HasColumnName("outras_doenca_infancia");
    //            entity.Property(e => e.OutrosHabitosNocivos)
    //                .HasMaxLength(200)
    //                .HasColumnName("outros_habitos_nocivos");
    //            entity.Property(e => e.QuaisMedicamentos)
    //                .HasMaxLength(400)
    //                .HasColumnName("quais_medicamentos");
    //            entity.Property(e => e.QueixaPrincipal)
    //                .HasMaxLength(400)
    //                .HasColumnName("queixa_principal");
    //            entity.Property(e => e.TemAlergiaMedicamentos).HasColumnName("tem_alergia_medicamentos");
    //            entity.Property(e => e.TeveAmigdalite).HasColumnName("teve_amigdalite");
    //            entity.Property(e => e.TeveAnginaOuDorTorax).HasColumnName("teve_angina_ou_dor_torax");
    //            entity.Property(e => e.TeveAnomaliasCongenitasCardiacas).HasColumnName("teve_anomalias_congenitas_cardiacas");
    //            entity.Property(e => e.TeveArritmias).HasColumnName("teve_arritmias");
    //            entity.Property(e => e.TeveCatapora).HasColumnName("teve_catapora");
    //            entity.Property(e => e.TeveFebreReumatica).HasColumnName("teve_febre_reumatica");
    //            entity.Property(e => e.TeveHipertensao).HasColumnName("teve_hipertensao");
    //            entity.Property(e => e.TeveInfartoDoMiocardio).HasColumnName("teve_infarto_do_miocardio");
    //            entity.Property(e => e.TevePatologiasDeValvulas).HasColumnName("teve_patologias_de_valvulas");
    //            entity.Property(e => e.TeveSarampo).HasColumnName("teve_sarampo");
    //            entity.Property(e => e.TeveSopros).HasColumnName("teve_sopros");
    //            entity.Property(e => e.VisitasMedicas)
    //                .HasMaxLength(150)
    //                .HasColumnName("visitas_medicas");

    //            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.Prontuarios)
    //                .HasForeignKey(d => d.IdPaciente)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("prontuario_ibfk_1");

    //            entity.HasOne(d => d.IdProfessorVinculadoNavigation).WithMany(p => p.Prontuarios)
    //                .HasForeignKey(d => d.IdProfessorVinculado)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("prontuario_ibfk_2");
    //        });

    //        modelBuilder.Entity<ProntuarioEstudante>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("prontuario_estudante");

    //            entity.HasIndex(e => e.IdProntuario, "id_prontuario");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.IdEstudante).HasColumnName("id_estudante");
    //            entity.Property(e => e.IdProntuario).HasColumnName("id_prontuario");

    //            entity.HasOne(d => d.IdProntuarioNavigation).WithMany(p => p.ProntuarioEstudantes)
    //                .HasForeignKey(d => d.IdProntuario)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("prontuario_estudante_ibfk_1");
    //        });

    //        modelBuilder.Entity<ProntuarioPmEstudante>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("prontuario_pm_estudante");

    //            entity.HasIndex(e => e.IdEstudante, "id_estudante");

    //            entity.HasIndex(e => e.IdProntuarioPm, "id_prontuario_pm");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.IdEstudante).HasColumnName("id_estudante");
    //            entity.Property(e => e.IdProntuarioPm).HasColumnName("id_prontuario_pm");

    //            entity.HasOne(d => d.IdEstudanteNavigation).WithMany(p => p.ProntuarioPmEstudantes)
    //                .HasForeignKey(d => d.IdEstudante)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("prontuario_pm_estudante_ibfk_1");

    //            entity.HasOne(d => d.IdProntuarioPmNavigation).WithMany(p => p.ProntuarioPmEstudantes)
    //                .HasForeignKey(d => d.IdProntuarioPm)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("prontuario_pm_estudante_ibfk_2");
    //        });

    //        modelBuilder.Entity<ProntuarioProntoAtendimento>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("prontuario_pronto_atendimento");

    //            entity.HasIndex(e => e.IdPaciente, "id_paciente");

    //            entity.HasIndex(e => e.IdProfessorVinculado, "id_professor_vinculado");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.AlergiaAlgumMedicamentoSubstancia).HasColumnName("alergia_algum_medicamento_substancia");
    //            entity.Property(e => e.AlunoAssinou).HasColumnName("aluno_assinou");
    //            entity.Property(e => e.ApresentaHistoriaFebreReumatica).HasColumnName("apresenta_historia_febre_reumatica");
    //            entity.Property(e => e.ApresentaHistoriaHemorragia).HasColumnName("apresenta_historia_hemorragia");
    //            entity.Property(e => e.Asma).HasColumnName("asma");
    //            entity.Property(e => e.Bronquite).HasColumnName("bronquite");
    //            entity.Property(e => e.CidadeFichaFeita)
    //                .HasMaxLength(100)
    //                .HasColumnName("cidade_ficha_feita");
    //            entity.Property(e => e.Cirrose).HasColumnName("cirrose");
    //            entity.Property(e => e.DataFichaFeita)
    //                .HasColumnType("date")
    //                .HasColumnName("data_ficha_feita");
    //            entity.Property(e => e.Diagnostico)
    //                .HasMaxLength(150)
    //                .HasColumnName("diagnostico");
    //            entity.Property(e => e.EDiabetico).HasColumnName("e_diabetico");
    //            entity.Property(e => e.EstaGravida).HasColumnName("esta_gravida");
    //            entity.Property(e => e.EstaSobTratamentoMedico).HasColumnName("esta_sob_tratamento_medico");
    //            entity.Property(e => e.EstaTomandoAlgumMedicamento).HasColumnName("esta_tomando_algum_medicamento");
    //            entity.Property(e => e.ExisteDoencaPredominanteFamilia).HasColumnName("existe_doenca_predominante_familia");
    //            entity.Property(e => e.FazUsoProteseCardiaca).HasColumnName("faz_uso_protese_cardiaca");
    //            entity.Property(e => e.Gastrite).HasColumnName("gastrite");
    //            entity.Property(e => e.Hepatite).HasColumnName("hepatite");
    //            entity.Property(e => e.HistoriaMolestiaAtual)
    //                .HasMaxLength(500)
    //                .HasColumnName("historia_molestia_atual");
    //            entity.Property(e => e.IdPaciente).HasColumnName("id_paciente");
    //            entity.Property(e => e.IdProfessorVinculado).HasColumnName("id_professor_vinculado");
    //            entity.Property(e => e.JaTomouAnestesiaOdontologica).HasColumnName("ja_tomou_anestesia_odontologica");
    //            entity.Property(e => e.MotivoTratamentoMedico)
    //                .HasMaxLength(150)
    //                .HasColumnName("motivo_tratamento_medico");
    //            entity.Property(e => e.Observacoes)
    //                .HasMaxLength(150)
    //                .HasColumnName("observacoes");
    //            entity.Property(e => e.OutrasInformacoesHabitosVicios)
    //                .HasMaxLength(150)
    //                .HasColumnName("outras_informacoes_habitos_vicios");
    //            entity.Property(e => e.Outros)
    //                .HasMaxLength(150)
    //                .HasColumnName("outros");
    //            entity.Property(e => e.OutrosDisturbiosRespiratorios)
    //                .HasMaxLength(150)
    //                .HasColumnName("outros_disturbios_respiratorios");
    //            entity.Property(e => e.PacienteAssinou).HasColumnName("paciente_assinou");
    //            entity.Property(e => e.PressaoArterialMmMmHg)
    //                .HasMaxLength(10)
    //                .HasColumnName("pressao_arterial_mm_mmHg");
    //            entity.Property(e => e.ProfessorAssinou).HasColumnName("professor_assinou");
    //            entity.Property(e => e.QualDisturbioCardiovascular)
    //                .HasMaxLength(150)
    //                .HasColumnName("qual_disturbio_cardiovascular");
    //            entity.Property(e => e.QualDoencaInfectoContagiosa)
    //                .HasMaxLength(150)
    //                .HasColumnName("qual_doenca_infecto_contagiosa");
    //            entity.Property(e => e.QualDoencaPredominante)
    //                .HasMaxLength(150)
    //                .HasColumnName("qual_doenca_predominante");
    //            entity.Property(e => e.QualMedicamento)
    //                .HasMaxLength(150)
    //                .HasColumnName("qual_medicamento");
    //            entity.Property(e => e.QualMedicamentoSubstancia)
    //                .HasMaxLength(150)
    //                .HasColumnName("qual_medicamento_substancia");
    //            entity.Property(e => e.QueixaPrincipal)
    //                .HasMaxLength(400)
    //                .HasColumnName("queixa_principal");
    //            entity.Property(e => e.SofreDisturbioGastroIntestinal).HasColumnName("sofre_disturbio_gastro_intestinal");
    //            entity.Property(e => e.SofreDisturbiosCardiovasculares).HasColumnName("sofre_disturbios_cardiovasculares");
    //            entity.Property(e => e.TemHipertensao).HasColumnName("tem_hipertensao");
    //            entity.Property(e => e.TeveAlgumaReacaoIndesejavel).HasColumnName("teve_alguma_reacao_indesejavel");
    //            entity.Property(e => e.TeveDoencaInfectoContagiosa).HasColumnName("teve_doenca_infecto_contagiosa");
    //            entity.Property(e => e.Ulcera).HasColumnName("ulcera");

    //            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.ProntuarioProntoAtendimentos)
    //                .HasForeignKey(d => d.IdPaciente)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("prontuario_pronto_atendimento_ibfk_1");

    //            entity.HasOne(d => d.IdProfessorVinculadoNavigation).WithMany(p => p.ProntuarioProntoAtendimentos)
    //                .HasForeignKey(d => d.IdProfessorVinculado)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("prontuario_pronto_atendimento_ibfk_2");
    //        });

    //        modelBuilder.Entity<ProntuarioStatus>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("prontuario_status");

    //            entity.HasIndex(e => e.IdProntuario, "id_prontuario");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.Descricao)
    //                .HasColumnType("enum('pendente','completo','incompleto')")
    //                .HasColumnName("descricao");
    //            entity.Property(e => e.IdProntuario).HasColumnName("id_prontuario");

    //            entity.HasOne(d => d.IdProntuarioNavigation).WithMany(p => p.ProntuarioStatuses)
    //                .HasForeignKey(d => d.IdProntuario)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("prontuario_status_ibfk_1");
    //        });

    //        modelBuilder.Entity<ReavaliacaoAnamnese>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("reavaliacao_anamnese");

    //            entity.HasIndex(e => e.IdPaciente, "id_paciente");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.Data)
    //                .HasColumnType("date")
    //                .HasColumnName("data");
    //            entity.Property(e => e.FrequenciaRespiratoria).HasColumnName("frequencia_respiratoria");
    //            entity.Property(e => e.IdPaciente).HasColumnName("id_paciente");
    //            entity.Property(e => e.IdProfessorResponsavel).HasColumnName("id_professor_responsavel");
    //            entity.Property(e => e.Medicamentos)
    //                .HasMaxLength(300)
    //                .HasColumnName("medicamentos");
    //            entity.Property(e => e.Observacoes)
    //                .HasMaxLength(450)
    //                .HasColumnName("observacoes");
    //            entity.Property(e => e.PressaoArterialDiastolica).HasColumnName("pressao_arterial_diastolica");
    //            entity.Property(e => e.PressaoArterialSistolica).HasColumnName("pressao_arterial_sistolica");
    //            entity.Property(e => e.Pulso).HasColumnName("pulso");
    //            entity.Property(e => e.TemperaturaAxilar).HasColumnName("temperatura_axilar");

    //            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.ReavaliacaoAnamneses)
    //                .HasForeignKey(d => d.IdPaciente)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("reavaliacao_anamnese_ibfk_1");
    //        });

    //        modelBuilder.Entity<TipoUsuario>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("tipo_usuario");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.Descricao)
    //                .HasColumnType("enum('administrador','professor','estudante')")
    //                .HasColumnName("descricao");
    //        });

    //        modelBuilder.Entity<Triagem>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("triagem");

    //            entity.HasIndex(e => e.IdPaciente, "id_paciente");

    //            entity.HasIndex(e => e.IdProfessorVinculado, "id_professor_vinculado");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.EncaminharPeriodo)
    //                .HasMaxLength(45)
    //                .HasColumnName("encaminhar_periodo");
    //            entity.Property(e => e.EspecializacaoCirurgia).HasColumnName("especializacao_cirurgia");
    //            entity.Property(e => e.EspecializacaoProteseImplante).HasColumnName("especializacao_protese_implante");
    //            entity.Property(e => e.IdPaciente).HasColumnName("id_paciente");
    //            entity.Property(e => e.IdProfessorVinculado).HasColumnName("id_professor_vinculado");
    //            entity.Property(e => e.OutrasEspecializacoes)
    //                .HasMaxLength(400)
    //                .HasColumnName("outras_especializacoes");
    //            entity.Property(e => e.Triagemcol)
    //                .HasMaxLength(45)
    //                .HasColumnName("triagemcol");

    //            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.Triagems)
    //                .HasForeignKey(d => d.IdPaciente)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("triagem_ibfk_1");

    //            entity.HasOne(d => d.IdProfessorVinculadoNavigation).WithMany(p => p.Triagems)
    //                .HasForeignKey(d => d.IdProfessorVinculado)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("triagem_ibfk_2");
    //        });

    //        modelBuilder.Entity<Usuario>(entity =>
    //        {
    //            entity.HasKey(e => e.Id).HasName("PRIMARY");

    //            entity.ToTable("usuario");

    //            entity.HasIndex(e => e.IdTipoUsuario, "id_tipo_usuario");

    //            entity.Property(e => e.Id).HasColumnName("id");
    //            entity.Property(e => e.Email)
    //                .HasMaxLength(150)
    //                .HasColumnName("email");
    //            entity.Property(e => e.IdTipoUsuario).HasColumnName("id_tipo_usuario");
    //            entity.Property(e => e.PasswordHash)
    //                .HasMaxLength(150)
    //                .HasColumnName("password_hash");

    //            entity.HasOne(d => d.IdTipoUsuarioNavigation).WithMany(p => p.Usuarios)
    //                .HasForeignKey(d => d.IdTipoUsuario)
    //                .OnDelete(DeleteBehavior.ClientSetNull)
    //                .HasConstraintName("usuario_ibfk_1");
    //        });

    //        OnModelCreatingPartial(modelBuilder);
    //    }

    //    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
