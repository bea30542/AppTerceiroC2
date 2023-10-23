using System;
using System.Collections.Generic;
using System.Text;

namespace AppTerceiroC
{
    public static class ComandoSQL
    {
        public static string inserirNome = "INSERT INTO `tbl_usuario`(`ID_ALUNO_CPF`, `NOME_DO_ALUNO`, `DATA_DE_NASCIMENTO`, `CONTATO_DE_EMERGENCIA`, `NOME_DO_RESPONSAVEL`, `ENDERECO1`, `ENDERECO2`,  `SERIE`) VALUES ('@ID_ALUNO_CPF','@NOME_DO_ALUNO','@DATA_DE_NASCIMENTO','@CONTATO_DE_EMERGENCIA','@NOME_DO_RESPONSAVEL','@ENDERECO1','@ENDERECO2','@SERIE')";
    }
}
