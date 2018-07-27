using System;
using System.Text.RegularExpressions;

namespace NotificationPattern.Validations {
    public partial class Contract {
        public Contract IsNotNullOrEmpty (string val, string property, string message) {
            if (string.IsNullOrEmpty (val))
                AddRuleNotification (property, message);

            return this;
        }

        public Contract IsNullOrEmpty (string val, string property, string message) {
            if (!string.IsNullOrEmpty (val))
                AddRuleNotification (property, message);

            return this;
        }

        public Contract HasMinLen (string val, int min, string property, string message) {
            if (string.IsNullOrEmpty (val) || val.Length < min)
                AddRuleNotification (property, message);

            return this;
        }

        public Contract HasMaxLen (string val, int max, string property, string message) {
            if (string.IsNullOrEmpty (val) || val.Length > max)
                AddRuleNotification (property, message);

            return this;
        }

        public Contract HasLen (string val, int len, string property, string message) {
            if (string.IsNullOrEmpty (val) || val.Length != len)
                AddRuleNotification (property, message);

            return this;
        }

        public Contract Contains (string val, string text, string property, string message) {
            if (!val.Contains (text))
                AddRuleNotification (property, message);

            return this;
        }

        public Contract AreEquals (string val, string text, string property, string message) {
            if (val != text)
                AddRuleNotification (property, message);

            return this;
        }

        public Contract AreNotEquals (string val, string text, string property, string message) {
            if (val == text)
                AddRuleNotification (property, message);

            return this;
        }

        public Contract IsEmail (string email, string property, string message) {
            const string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            if (!Regex.IsMatch (email ?? "", pattern))
                AddRuleNotification (property, message);

            return this;
        }

        public Contract IsEmailOrEmpty (string email, string property, string message) {
            if (string.IsNullOrEmpty (email))
                return this;

            return IsEmail (email, property, message);
        }

        public Contract IsUrl (string url, string property, string message) {
            const string pattern = @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$";
            if (!Regex.IsMatch (url ?? "", pattern))
                AddRuleNotification (property, message);

            return this;
        }

        public Contract IsUrlOrEmpty (string url, string property, string message) {
            if (string.IsNullOrEmpty (url))
                return this;

            return IsUrl (url, property, message);
        }

        public Contract IsCnpj (string cnpj, string property, string message) {
            if (String.IsNullOrWhiteSpace (cnpj))
                AddRuleNotification (property, message);

            cnpj = cnpj.Trim ();
            cnpj = cnpj.Replace (".", "").Replace ("-", "").Replace ("/", "");

            if (cnpj.Length != 14)
                AddRuleNotification (property, message);

            int[] multiplier1 = new [] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplier2 = new [] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum;
            int rest;
            string digit;
            string tempCnpj;

            if (cnpj.Equals ("00000000000000") ||
                cnpj.Equals ("11111111111111") ||
                cnpj.Equals ("22222222222222") ||
                cnpj.Equals ("33333333333333") ||
                cnpj.Equals ("44444444444444") ||
                cnpj.Equals ("55555555555555") ||
                cnpj.Equals ("66666666666666") ||
                cnpj.Equals ("77777777777777") ||
                cnpj.Equals ("88888888888888") ||
                cnpj.Equals ("99999999999999") ||
                cnpj.Equals ("12345678912345"))

            {
                AddRuleNotification (property, message);
            }

            tempCnpj = cnpj.Substring (0, 12);
            sum = 0;

            for (int i = 0; i < 12; i++)
                sum += int.Parse (tempCnpj[i].ToString ()) * multiplier1[i];

            rest = (sum % 11);

            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;

            digit = rest.ToString ();
            tempCnpj = tempCnpj + digit;
            sum = 0;

            for (int i = 0; i < 13; i++)
                sum += int.Parse (tempCnpj[i].ToString ()) * multiplier2[i];

            rest = (sum % 11);

            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;

            digit = digit + rest.ToString ();

            return this;

        }

        public Contract IsCpf (string cpf, string property, string message) {

            if (cpf == null)
                AddRuleNotification (property, message);

            var position = 0;
            var totalDigit1 = 0;
            var totalDigit2 = 0;
            var verifyingDigit1 = 0;
            var verifyingDigit2 = 0;

            bool digitosIdenticos = true;
            var ultimoDigito = -1;

            foreach (var c in cpf) {
                if (char.IsDigit (c)) {
                    var digito = c - '0';
                    if (position != 0 && ultimoDigito != digito) {
                        digitosIdenticos = false;
                    }

                    ultimoDigito = digito;
                    if (position < 9) {
                        totalDigit1 += digito * (10 - position);
                        totalDigit2 += digito * (11 - position);
                    } else if (position == 9) {
                        verifyingDigit1 = digito;
                    } else if (position == 10) {
                        verifyingDigit2 = digito;
                    }

                    position++;
                }
            }

            if (position > 11)
                AddRuleNotification (property, message);

            if (digitosIdenticos)
                AddRuleNotification (property, message);

            var digito1 = totalDigit1 % 11;
            digito1 = digito1 < 2 ? 0 : 11 - digito1;

            if (verifyingDigit1 != digito1)
                AddRuleNotification (property, message);

            totalDigit2 += digito1 * 2;
            var digito2 = totalDigit2 % 11;
            digito2 = digito2 < 2 ?
                0 :
                11 - digito2;

            return this;

        }
    }
}