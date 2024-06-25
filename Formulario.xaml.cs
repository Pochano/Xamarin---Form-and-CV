﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DBP_Xamarin.Principal;

namespace DBP_Xamarin.Principal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formulario : ContentPage
    {
        string nombre;
        string apellido;
        string dia;
        string mes;
        string año;
        string ocupacion;
        string celular;
        string correo_electronico;
        string aptitudes;
        string experiencia_laboral;
        string formacion_academica;

        public Formulario()
        {
            InitializeComponent();
        }

        public void Insertar_Datos()
        {

            nombre = Convert.ToString(Nombre_i.Text);
            apellido = Convert.ToString(Apellidos_i.Text);
            dia = Convert.ToString(Dia_i.Text);
            mes = Convert.ToString(Mes_i.Text);
            año = Convert.ToString(Año_i.Text);
            ocupacion = Convert.ToString(Ocupacion_i.Text);
            celular = Convert.ToString(Telefono_i.Text);
            correo_electronico = Convert.ToString(Correo_i.Text);
            aptitudes = Convert.ToString(Aptitudes_i.Text);
            experiencia_laboral = Convert.ToString(Experiencia_i.Text);
            formacion_academica = Convert.ToString(Formacion_i.Text);


            Label labelNombre = new Label { Text = $"Nombre: {Environment.NewLine + nombre}", Margin = new Thickness(20, 10, 20, 10), TextColor = Color.Black, FontSize = 20 };

            Label labelApellido = new Label
            {
                Text = $"Apellido: " +
                $"{Environment.NewLine + apellido}",
                Margin = new Thickness(20, 10, 20, 10),
                TextColor = Color.Black,
                FontSize = 20
            };

            Label labelFechaNacimiento = new Label
            {
                Text = $"Fecha de Nacimiento: " +
                $"{Environment.NewLine + dia} / {mes} / {año}",
                Margin = new Thickness(20, 10, 20, 10),
                TextColor = Color.Black,
                FontSize = 20
            };

            Label labelOcupacion = new Label
            {
                Text = $"Ocupacion: " +
                $"{Environment.NewLine + ocupacion}",
                Margin = new Thickness(20, 0, 20, 10),
                TextColor = Color.Black,
                FontSize = 20
            };

            Label labelCelular = new Label
            {
                Text = $"Celular: " +
                $"{Environment.NewLine + celular}",
                Margin = new Thickness(20, 0, 20, 10),
                TextColor = Color.Black,
                FontSize = 20
            };

            Label labelCorreo = new Label
            {
                Text = $"Correo Electrónico: " +
                $"{Environment.NewLine + correo_electronico}",
                Margin = new Thickness(20, 0, 20, 10),
                TextColor = Color.Black,
                FontSize = 20
            };

            Label labelAptitudes = new Label
            {
                Text = $"Aptitudes:" +
                $" {Environment.NewLine + aptitudes}",
                Margin = new Thickness(20, 0, 20, 10),
                TextColor = Color.Black,
                FontSize = 20
            };

            Label labelExperienciaLaboral = new Label
            {
                Text = $"Experiencia Laboral: " +
                $"{Environment.NewLine + experiencia_laboral}",
                Margin = new Thickness(20, 0, 20, 10),
                TextColor = Color.Black,
                FontSize = 20
            };

            Label labelFormacionAcademica = new Label
            {
                Text = $"Formación Académica: " +
                $"{Environment.NewLine + formacion_academica}",
                Margin = new Thickness(20, 0, 20, 10),
                TextColor = Color.Black,
                FontSize = 20
            };

            Datos_Ingresados.Children.Clear();

            Datos_Ingresados.Children.Add(labelNombre);
            Datos_Ingresados.Children.Add(labelApellido);
            Datos_Ingresados.Children.Add(labelFechaNacimiento);
            Datos_Ingresados.Children.Add(labelOcupacion);
            Datos_Ingresados.Children.Add(labelCelular);
            Datos_Ingresados.Children.Add(labelCorreo);
            Datos_Ingresados.Children.Add(labelAptitudes);
            Datos_Ingresados.Children.Add(labelExperienciaLaboral);
            Datos_Ingresados.Children.Add(labelFormacionAcademica);
            Datos_Ingresados.Children.Add(labelExperienciaLaboral);

        }

        public void Verificar()
        {
            if (string.IsNullOrEmpty(Nombre_i.Text))
            {
                DisplayAlert("Incompleto", "Asegúrese de ingresar el nombre", "Ok");
                return;
            }

            if (string.IsNullOrEmpty(Apellidos_i.Text))
            {
                DisplayAlert("Incompleto", "Asegúrese de ingresar los apellidos", "Ok");
                return;
            }

            if (string.IsNullOrEmpty(Dia_i.Text) || !int.TryParse(Dia_i.Text, out int dia) || dia < 1 || dia > 31)
            {
                DisplayAlert("Incompleto", "Asegúrese de ingresar un día válido", "Ok");
                return;
            }

            if (string.IsNullOrEmpty(Mes_i.Text) || !int.TryParse(Mes_i.Text, out int mes) || mes < 1 || mes > 12)
            {
                DisplayAlert("Incompleto", "Asegúrese de ingresar un mes válido", "Ok");
                return;
            }

            if (string.IsNullOrEmpty(Año_i.Text) || !int.TryParse(Año_i.Text, out int año) || año < 1900 || año > 2024)
            {
                DisplayAlert("Incompleto", "Asegúrese de ingresar un año válido", "Ok");
                return;
            }

            if ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia > 30)
            {
                DisplayAlert("Incompleto", "El mes ingresado solo tiene 30 días", "Ok");
                return;
            }

            if (mes == 2)
            {
                bool esBisiesto = (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0));
                if (esBisiesto && dia > 29)
                {
                    DisplayAlert("Incompleto", "Febrero en año bisiesto solo tiene hasta 29 días", "Ok");
                    return;
                }
                else if (!esBisiesto && dia > 28)
                {
                    DisplayAlert("Incompleto", "Febrero solo tiene hasta 28 días", "Ok");
                    return;
                }
            }

            if (string.IsNullOrEmpty(Ocupacion_i.Text))
            {
                DisplayAlert("Incompleto", "Asegúrese de ingresar la ocupación", "Ok");
                return;
            }

            if (string.IsNullOrEmpty(Telefono_i.Text))
            {
                DisplayAlert("Incompleto", "Asegúrese de ingresar el teléfono", "Ok");
                return;
            }

            if (string.IsNullOrEmpty(Correo_i.Text))
            {
                DisplayAlert("Incompleto", "Asegúrese de ingresar el correo electrónico", "Ok");
                return;
            }

            string tmp = Convert.ToString(Correo_i.Text);

            for (int i = 1; i < tmp.Length; i++)
            {

                if(tmp[0] == '@')
                {
                    DisplayAlert("Invalido", "Asegúrese de ingresar correctamente el correo electrónico", "Ok");
                    return;
                }
                if (tmp[i] == '@')
                {
                    break;
                }
                else if (i == tmp.Length-1)
                {
                    DisplayAlert("Invalido", "Asegúrese de ingresar un correo electrónico", "Ok");
                    return;
                }
            }

            if (string.IsNullOrEmpty(Aptitudes_i.Text))
            {
                DisplayAlert("Incompleto", "Asegúrese de ingresar las aptitudes", "Ok");
                return;
            }

            if (string.IsNullOrEmpty(Experiencia_i.Text))
            {
                DisplayAlert("Incompleto", "Asegúrese de ingresar la experiencia", "Ok");
                return;
            }

            if (string.IsNullOrEmpty(Formacion_i.Text))
            {
                DisplayAlert("Incompleto", "Asegúrese de ingresar la formación", "Ok");
                return;
            }

            // Todos los campos están verificados, insertar datos
            Insertar_Datos();
        }

        private void Enviar_Clicked(object sender, EventArgs e)
        {
            Verificar();
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            Nombre_i.Text = string.Empty;
            Apellidos_i.Text = string.Empty;   
            Dia_i.Text = string.Empty;
            Mes_i.Text = string.Empty;
            Año_i.Text = string.Empty;
            Ocupacion_i.Text = string.Empty;
            Telefono_i.Text = string.Empty;
            correo_electronico = string.Empty;
            Aptitudes_i.Text = string.Empty;
            Experiencia_i.Text = string.Empty;
            Formacion_i.Text = string.Empty;

            Datos_Ingresados.Children.Clear();
        }
    }
}

