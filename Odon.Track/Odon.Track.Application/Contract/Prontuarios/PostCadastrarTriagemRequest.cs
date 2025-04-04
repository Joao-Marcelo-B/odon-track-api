﻿namespace Odon.Track.Application.Contract.Prontuarios
{
    public class PostCadastrarTriagemRequest
    {
        public int IdPaciente { get; set; }
        public int IdUsuario { get; set; }
        public List<Tratamento> Tratamentos { get; set; }
        public int EncaminharPeriodo { get; set; }

        public bool EspecializacaoCirurgia { get; set; }
        public bool EspecializacaoProteseImplante { get; set; }
        public string OutrasEspecializacoes { get; set; }
        public List<EHorarioDisponivelAtendimento> HorariosDisponiveisAtendimento { get; set; }
        public int Status {  get; set; }
    }

    public class Tratamento
    {
        public ETratamento TipoTratamento { get; set; }
        public string Descricao { get; set; }
    }

    public enum EHorarioDisponivelAtendimento
    {
        sete_meia,
        nove_meia,
        uma_meia,
        tres_meia,
    }

    public enum ETratamento
    {
        periodontia,
        endodontia,
        dentistica,
        cirurgia,
        protese,
    }
}
