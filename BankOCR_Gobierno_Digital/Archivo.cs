namespace BankOCR_Gobierno_Digital
{
    class Archivo
    {
        public string ruta_archivo { set; get; }

        string[] LeerArchivo()
        {
            string[] texto_arhivo = System.IO.File.ReadAllLines(ruta_archivo);
            return texto_arhivo;
        }

        private string interprete(string[][] arreglo)
        {
            string numero = string.Empty;

            int tam = arreglo[0].Length;

            switch (tam)
            {
                case 1:
                    if (arreglo[0][0].Equals(" ") && 
                        arreglo[1][0].Equals("|") &&
                        arreglo[2][0].Equals("|")){

                        numero = "1";
                    }
                    break;
                case 2:
                    if (
                        arreglo[0][0].Equals("-") && arreglo[1][0].Equals(" ") &&
                        arreglo[0][1].Equals("-") && arreglo[1][1].Equals("|") &&
                        arreglo[0][2].Equals("-") && arreglo[1][2].Equals("|")
                        ){

                        numero = "3";
                    }else if (
                        arreglo[0][0].Equals("-") && arreglo[1][0].Equals(" ") &&
                        arreglo[0][1].Equals(" ") && arreglo[1][1].Equals("|") &&
                        arreglo[0][2].Equals(" ") && arreglo[1][2].Equals("|")
                        )
                    {
                        numero = "7";
                    }
                    break;
                case 3:
                    if (
                        arreglo[0][0].Equals(" ") && arreglo[1][0].Equals("-") && arreglo[2][0].Equals(" ") &&
                        arreglo[0][1].Equals(" ") && arreglo[1][1].Equals("-") && arreglo[2][1].Equals("|") &&
                        arreglo[0][2].Equals("|") && arreglo[1][2].Equals("-") && arreglo[2][2].Equals(" ")
                        )
                    {
                        numero = "2";
                    }else if (
                        arreglo[0][0].Equals(" ") && arreglo[1][0].Equals(" ") && arreglo[2][0].Equals(" ") &&
                        arreglo[0][1].Equals("|") && arreglo[1][1].Equals("-") && arreglo[2][1].Equals("|") &&
                        arreglo[0][2].Equals(" ") && arreglo[1][2].Equals(" ") && arreglo[2][2].Equals("|")
                        )
                    {
                        numero = "4";
                    }else if (
                        arreglo[0][0].Equals(" ") && arreglo[1][0].Equals("-") && arreglo[2][0].Equals(" ") &&
                        arreglo[0][1].Equals("|") && arreglo[1][1].Equals("-") && arreglo[2][1].Equals(" ") &&
                        arreglo[0][2].Equals(" ") && arreglo[1][2].Equals("-") && arreglo[2][2].Equals("|")
                        )
                    {
                        numero = "5";
                    }else if (
                        arreglo[0][0].Equals(" ") && arreglo[1][0].Equals("-") && arreglo[2][0].Equals(" ") &&
                        arreglo[0][1].Equals("|") && arreglo[1][1].Equals("-") && arreglo[2][1].Equals(" ") &&
                        arreglo[0][2].Equals("|") && arreglo[1][2].Equals("-") && arreglo[2][2].Equals("|")
                        )
                    {
                        numero = "6";
                    }else if (
                        arreglo[0][0].Equals(" ") && arreglo[1][0].Equals("-") && arreglo[2][0].Equals(" ") &&
                        arreglo[0][1].Equals("|") && arreglo[1][1].Equals("-") && arreglo[2][1].Equals("|") &&
                        arreglo[0][2].Equals("|") && arreglo[1][2].Equals("-") && arreglo[2][2].Equals("|")
                        )
                    {
                        numero = "8";
                    }else if (
                        arreglo[0][0].Equals(" ") && arreglo[1][0].Equals("-") && arreglo[2][0].Equals(" ") &&
                        arreglo[0][1].Equals("|") && arreglo[1][1].Equals("-") && arreglo[2][1].Equals("|") &&
                        arreglo[0][2].Equals(" ") && arreglo[1][2].Equals(" ") && arreglo[2][2].Equals("|")
                        )
                    {
                        numero = "9";
                    }
                    break;
                default:
                    numero = "?";
                    break;
            }

            return numero;
        }

        public void recorre_arr_archivo(ListBox lb_resultados)
        {
            string[] texto_archivo = LeerArchivo();

            string[][] arrTemp = new string[texto_archivo.Length][];

            for(int i = 0; i<texto_archivo.Length ; i++)
            {
               string linea = texto_archivo[i];

                Console.WriteLine("Linea " + i + " - " + linea);
                arrTemp[i] = new string[linea.Length];

                for(int j = 0; j < linea.Length; j++)
                {
                    string valor = linea.Substring(j,1);
                    arrTemp[i][j] = valor;
                }
            }

            bool continua = true;
            bool continua2 = false;
            int i2 = 0;
            int comp = arrTemp[0].Length;
            do
            {
                if (arrTemp[i2].Length != comp)
                {
                    continua = false;
                    continua2 = false;
                }
                i2++;

                if(i2 == arrTemp.Length)
                {
                    continua = false;
                    continua2 = true;
                }
            } while(continua == true);

            if (continua2 == true)
            {
                int[] indices_separador = new int[8];
                int l2 = 0;

                for(int l = 0; l<comp; l++)
                {
                    string v0 = arrTemp[0][l];
                    string v1 = arrTemp[1][l];
                    string v2 = arrTemp[2][l];

                    if(v0.Equals(" ") && v1.Equals(" ") && v2.Equals(" "))
                    {
                       indices_separador[l2] = l;
                        l2++;
                    }
                }

                string[] arrNumeros = new string[9];
                string[][] arrTemp2 = new string[3][];

                int tope = 0;
                int indiceArr = 0;
                int l3 = 0;
                //int ciclo = 1;
                //bool continua3 = true;

                int inicio = 0;
                int iniArr = 0;

                for (int ciclo = 1; ciclo < 9; ciclo++)
                {
                    indiceArr = indices_separador[l3];

                    int tamArreglo = indiceArr - (ciclo * l3);
                    arrTemp2[0] = new string[tamArreglo];
                    arrTemp2[1] = new string[tamArreglo];
                    arrTemp2[2] = new string[tamArreglo];

                    
                    for (int m2 = 0; m2 < tamArreglo; m2++)
                    {
                        if(m2 == 0)
                        {
                            inicio = indiceArr - tamArreglo;
                        }
                        else
                        {
                            inicio++;
                        }

                        arrTemp2[0][m2] = arrTemp[0][inicio];
                        arrTemp2[1][m2] = arrTemp[1][inicio];
                        arrTemp2[2][m2] = arrTemp[2][inicio];
                    }
                    string num = interprete(arrTemp2);
                    arrNumeros[iniArr] = num;

                    //inicio = inicio + 2;
                    iniArr++;

                    l3++;
                    tope++;
                }

                /*for(int m = 0; m<arrTemp.Length; m++)
                {
                    arrTemp2[0] = new string[m];
                    arrTemp2[1] = new string[m];
                    arrTemp2[2] = new string[m];
                }*/
            }
            else 
            {
                string texto = "El Archivo no Contiene Digitos Legibles";
                lb_resultados.Items.Add(texto);
            }
        }
    }
}
