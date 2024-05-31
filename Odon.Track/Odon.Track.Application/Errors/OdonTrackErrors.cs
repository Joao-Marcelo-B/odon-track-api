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
        public static string RolesSemestreAlreadyExists = "Essa regra já está associada a outro semestre";
        public static string RolesNotFound = "Essa regra de autorização não existe ou não foi encontrada";
        public static string RolesSemestreNotFound = "Essa regra não existe ou não foi encontrada";
        public static string SenhaAtualInvalid = "Sua senha atual não está correta";
        public static string SenhasIguais = "Nova senha não pode ser igual a senha Atual";
    }
}
