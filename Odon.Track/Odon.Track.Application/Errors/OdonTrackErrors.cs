namespace Odon.Track.Application.Errors
{
    public static class OdonTrackErrors
    {
        public static string RequestInvalid = "Requisição inválida";
        public static string UsuarioNotFound = "Esse usuário não existe";
        public static string CredenciaisInvalid = "As credênciais estão inválidas";
        public static string EmailUsed = "Esse email já foi cadastrado";
        public static string EmailUnifenasInvalid = "Esse email não corresponde ao email institucional";
        public static string IdentificadorUsed = "Identificador Unifenas em uso";
        public static string PasswordNotMatched = "As senhas não são iguais";
        public static string EstudanteNotFound = "Estudante não encontrado";
        public static string UsuarioBlocked = "Esse usuário está bloqueado, entre em contato com um professor para liberar o acesso";
        public static string UsuarioBlockedForLoginFailed = "Bloqueado por excesso de tentativas de login com falha, troque a senha ou entre em contato com o administrador";
        public static string RolesSemestreAlreadyExists = "Essa regra já está associada a outro semestre";
        public static string RolesNotFound = "Essa regra de autorização não existe ou não foi encontrada";
        public static string RolesSemestreNotFound = "Essa regra não existe ou não foi encontrada";
        public static string SenhaAtualInvalid = "Sua senha atual não está correta";
        public static string SenhasIguais = "Nova senha não pode ser igual a senha Atual";
        public static string CPFJaCadastrado = "Esse CPF já está vinculado com outro paciente";
        public static string PacienteNotFound = "Paciente não encontrado";
        public static string CPFInvalido = "Número do CPF inválido";
        public static string EnderecoPendente = "É necessário cadastrar o endereço antes de preencher a triagem";
        public static string TriagemFound = "Esse paciente já possui uma ficha de triagem";
        public static string ProfessorNotFound = "Professor não exite";
        public static string TriagemNotFound = "Triagem não exite";
        public static string ResponsavelNotFound = "Responsavel não exite";
        public static string EnderecoNotFound = "Endereço não exite";
        public static string ConsultaNotFound = "Consulta não encontrada";
        public static string ImagemEmpty = "Arquivo de imagem vazia.";
        public static string ImagemInvalid = "Tipo de arquivo não permitido.";
        public static string ImagemNotFound = "Imagem não existe ou não encontrada.";
        public static string ProntuarioNotFound = "Esse prontuário não foi encontrado ou não existe.";
        public static string ProntuarioJaExiste = "Esse paciente já possui um prontuário.";
    }
}
