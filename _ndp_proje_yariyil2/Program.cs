/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**				BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					2024-2025 BAHAR DÖNEMÝ
**	
**				ÖDEV NUMARASI..........: Proje
**				ÖÐRENCÝ ADI............: Ahmet Faruk Ýkiz
**				ÖÐRENCÝ NUMARASI.......: B241210040   
**              DERSÝN ALINDIÐI GRUP...: B Grubu
****************************************************************************/

namespace _ndp_proje_yariyil2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new GirisMenuForm());
        }
    }
}