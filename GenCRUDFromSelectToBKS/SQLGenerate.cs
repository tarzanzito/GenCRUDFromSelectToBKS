namespace MakeCRUDFromSelect
{

    /// <summary>
    /// Generate CRUD from a simple select statement
    /// </summary>
    public class SQLGenerate
    {
        private string _schemaName = null;
        private string _schemaVar = "$SCHEMA";
        private string _tableName = null;
        private string _wheres = null;
        private bool _wheresMaked = false;

        System.Collections.Generic.List<string> _columnsInfo = new System.Collections.Generic.List<string>();

        /// <summary>
        /// Get information from a simple Select statement
        /// </summary>
        /// <param name="text"></param>
        public void MountFromSelectStatement(string text)
        {
            _columnsInfo = new System.Collections.Generic.List<string>();
            _schemaName = null;
            _tableName = null;

            string temp = null;
            temp = text.Replace("\r", "").Replace("\n", " ").ToUpper().Trim();
            int pos = temp.IndexOf("SELECT ");
            temp = temp.Substring(pos + 6, temp.Length - pos - 6);

            pos = temp.IndexOf("FROM ");

            string left = temp.Substring(0, pos).Trim().Replace(" ", "");
            string right = temp.Substring(pos + 4, temp.Length - pos - 4).Trim();

            //Columns
            char[] chrs = new char[1] { ',' };

            string[] columnsName = left.Split(chrs);

            int t = columnsName.Length;

            for (int i = 0; i < t; i++)
                _columnsInfo.Add(columnsName[i]);

            //Schema and Table
            char[] chrsB = new char[1] { '.' };
            string[] schemaAndTable = right.Split(chrsB);
            if (schemaAndTable.Length == 2)
            {
                _schemaName = schemaAndTable[0];
                _tableName = schemaAndTable[1];
            }
            else
                _tableName = schemaAndTable[0];

        }


        /// <summary>
        /// Generate SELECT statement with variables
        /// </summary>
        /// <returns></returns>
        public string GenerateSelect()
        {
            if (this._columnsInfo == null)
                return "";

            if (this._columnsInfo.Count == 0)
                return "";

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine("SELECT ");

            string separator = ",";
            string spaces = "    ";

            int t = this._columnsInfo.Count;

            for (int i = 0; i < t; i++)
            {
                if (i == (t - 1))
                    separator = "";

                string name = this._columnsInfo[i];
                sb.AppendLine(spaces + name + separator);
            }

            sb.AppendLine("FROM " + _schemaVar + "." + this._tableName);

            ////WHEREs
             if (!_wheresMaked)
                _wheres = GenerateWheres();

             if (_wheres.Length > 0)
                sb.AppendLine(_wheres);

            return sb.ToString();
        }

        /// <summary>
        /// Generate INSERT statement with variables
        /// </summary>
        /// <returns></returns>
        public string GenerateInsert()
        {
            if (this._columnsInfo == null)
                return "";

            if (this._columnsInfo.Count == 0)
                return "";

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine("INSERT INTO " + _schemaVar + "." + this._tableName);
            sb.AppendLine("(");

            string separator = ",";
            string spaces = "    ";

            int t = this._columnsInfo.Count;

            for (int i = 0; i < t; i++)
            {
                if (i == (t - 1))
                    separator = "";

                string name = this._columnsInfo[i];
                sb.AppendLine(spaces + name + separator);
            }

            sb.AppendLine(")");
            sb.AppendLine("VALUES");
            sb.AppendLine("(");

            separator = ",";

            for (int i = 0; i < t; i++)
            {
                if (i == (t - 1))
                    separator = "";

                string name = this._columnsInfo[i];
                sb.AppendLine(spaces + "{" + name.ToLower() + "}" + separator);
            }

            sb.AppendLine(")");

            return sb.ToString();
        }

        /// <summary>
        /// Generate UPDATE statement with variables
        /// </summary>
        /// <returns></returns>
        public string GenerateUpdate()
        {
            if (this._columnsInfo == null)
                return "";

            if (this._columnsInfo.Count == 0)
                return "";

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine("UPDATE " + _schemaVar + "." + this._tableName);
            sb.AppendLine("SET");

            string separator = ",";
            string spaces = "    ";

            int t = this._columnsInfo.Count;

            for (int i = 0; i < t; i++)
            {
                if (i == (t - 1))
                    separator = "";

                string name = this._columnsInfo[i];
                sb.AppendLine(spaces + name + " = " + "{" + name.ToLower() + "}" + separator);
            }

            //WHERE
            if (!_wheresMaked)
                _wheres = GenerateWheres();

            if (_wheres.Length > 0)
                sb.AppendLine(_wheres);

            return sb.ToString();
        }

        /// <summary>
        /// Generate DELETE statement
        /// </summary>
        /// <returns></returns>
        public string GenerateDelete()
        {
            if (this._columnsInfo == null)
                return "";

            if (this._columnsInfo.Count == 0)
                return "";

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine("DELETE FROM " + _schemaVar + "." + this._tableName);

            ////WHEREs
            if (!_wheresMaked)
                _wheres = GenerateWheres();

            if (_wheres.Length > 0)
                sb.AppendLine(_wheres);

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GenerateWheres()
        {
            //Not possible: we dont have information about indexes
            //System.Text.StringBuilder sb = new System.Text.StringBuilder();
            return ""; // sb.ToString();
        }
    }
}
