// ZapisujęTowary.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
#include <fstream>
#include <string>
using namespace std;

class Program
{
public:
    //Menu
    void StartMenu();
    void InMenu();

    //Product managment
    void DodajProdukt();
    void UsunProdukt();
    bool WyswietlProdukty(bool ToMenu);
    void StaraSesja();
    void StertaStarychSavow();

    string GetUserName();
    
    bool NewSession = true;
    string FileName;
    string UserName;
};

Program* Towary = new Program;

int main()
{
    setlocale(LC_CTYPE, "Polish");
    Towary->StartMenu();
}

void Program::StartMenu()
{
    string Selected;
    for (;;)
    {
        cout << "Menu" << endl;
        cout << "1. Wczytaj poprzednią sesję." << endl;
        cout << "2. Twórz nową sesję." << endl;
        cin >> Selected;

        if (Selected == "1" || Selected == "2")
        {
            break;
        }
        else
        {
            system("cls");
            cout << "Podaj poprawny zakres między 1 a 2" << endl;
        }
    }
    if (Selected == "1")
    {
        //Wczytaj poprzednią sesję 
        system("cls");
        Towary->StaraSesja();
    }
    else if (Selected == "2")
    {
        Towary->NewSession = true;
        system("cls");
        cout << "Podaj nazwę użytkownika :" << endl;
        cin >> Towary->UserName;

        cout << "Podaj nazwę zapisu :" << endl;
        cin >> Towary->FileName;

        string SaveFile = "Helper";
        ifstream fin(SaveFile.c_str());

        char ch;

        string AllSaves = "";
        while (fin.get(ch))
        {
            AllSaves = AllSaves + ch;
        }
        fin.close();

        ofstream fout(SaveFile.c_str());

        fout << Towary->FileName << endl;
        fout.close();

        string File = Towary->FileName;
        ofstream fout2(File.c_str());
        fout2 << "[USER]" << endl;
        fout2 << Towary->UserName << endl;
        fout2 << "" << endl;
        fout2.close();

        system("cls");
        Towary->InMenu();
    }
}

void Program::DodajProdukt()
{
    string File = Towary->FileName;

    ifstream fin(File.c_str());

    char ch;

    string AllProdukts = "";
    while (fin.get(ch))
    {
        AllProdukts = AllProdukts + ch;
    }
    fin.close();
    
    
    ofstream fout(File.c_str());

    fout << AllProdukts;
    

    string ProductName = "";
    int index = 0;
    int ProductQuanlity = 0;
    int ProductPrice = 0;
    bool ProductActive = true;

    cout << "Product's name :" << endl;
    cin >> ProductName;

    cout << "Product quanlity :" << endl;
    cin >> ProductQuanlity;

    cout << "Product price" << endl;
    float price = 0.0;
    cin >> price;

    ProductQuanlity = price * 100;

    fout << "[PA]" << endl;
    fout << ProductActive << endl;

    fout << "[PI]" << endl;
    fout << index << endl;

    fout << "[PN]" << endl;
    fout << ProductName << endl;

    fout << "[PQ]" << endl;
    fout << ProductQuanlity << endl;

    fout << "[PP]" << endl;
    fout << ProductPrice << endl;

    fout << "" << endl;

    fout.close();

    system("cls");

    Towary->InMenu();   
}

void Program::UsunProdukt()
{
    if (Towary->WyswietlProdukty(false))
    {
        cout << "Wpisz element do usunięcia" << endl;
        int indexToDelete = 0;
        cin >> indexToDelete;

        string last = "";
        string line = "";
        ifstream File(Towary->FileName);
        int index = 0;
        int HowManyLines = 0;
        int lineNumber = 0;

        for (;;)
        {
            getline(File, line);
            if (last == "" && line == "")
            {
                break;
            }
            last = line;
            HowManyLines = HowManyLines + 1;

        }

        File.close();

        string* Tab;
        Tab = new string[HowManyLines];

        ifstream FileV2(Towary->FileName);

        for (int i = 0; i < HowManyLines; i++)
        {
            getline(FileV2, line);
            Tab[i] = line;
            if (line == "[PA]")
            {
                index = index + 1;
                if (index == indexToDelete)
                {
                    lineNumber = i + 1;
                }
            }
        }
        Tab[lineNumber] = "0";

        FileV2.close();

        string filetosave = Towary->FileName;
        ofstream fout(filetosave.c_str());

        for (int i = 0; i < HowManyLines; i++)
        {
            fout << Tab[i] << endl;
        }

        system("cls");

        cout << "Pomyślnie usunięto produkt" << endl;

    }
    Towary->InMenu();
}

bool Program::WyswietlProdukty(bool ToMenu)
{
    string last = "";
    string line = "";
    ifstream File(Towary->FileName);

    bool PrintInfo = true;
    bool Foundedany = false;
    int index = 0;
    for (;;)
    {
        getline(File, line);
        
        if (line == "[PA]")
        {
            getline(File, line);

            if (line == "1")
            {
                PrintInfo = true;
                Foundedany = true;
            }
            else
            {
                PrintInfo = false;
            }
        }
        else if (line == "[PN]")
        {
            if (PrintInfo)
            {
                getline(File, line);
                cout << "Product nr " << index + 1 << " name : " << line << endl;
            }
        }
        else if (line == "[PQ]")
        {
            if (PrintInfo)
            {
                getline(File, line);
                cout << "Product nr " << index + 1 << " quantity : " << line << endl;
            }
        }
        else if (line == "[PP]")
        {
            if (PrintInfo)
            {
                getline(File, line);
                cout << "Product nr " << index + 1<< " price : " << stold(line) / 100 << endl;

                index = index + 1;
            }
        }

        if (last == "" && line == "")
        {
            break;
        }
        last = line;
    }
    if (Foundedany == false)
    {
        cout << "Niestety nie znaleźliśmy żadnego produktu" << endl;
    }
    if (ToMenu)
    {
        Towary->InMenu();
    }
    
    return Foundedany;
}

void Program::StaraSesja()
{
    string lFileName;
    cout << "Wpisz nazwę zapisu pliku :" << endl;
    cin >> lFileName;
    
    ifstream fin(lFileName.c_str());

    if (fin.fail())
    {
        //Nie udało się otworzyć pliku 
        string SelectedOption;

        for (;;)
        {
            cout << "Wpisałeś / aś nie poprawną nazwę pliku, wybierz opcję :" << endl;
            cout << "1. Wybierz spośród splików." << endl;
            cout << "2. Spróbuj ponownie spisać nazwę pliku." << endl;
            cout << "3. Powrót do menu startowego" << endl;
            cin >> SelectedOption;

            if (SelectedOption == "1" || SelectedOption == "2" || SelectedOption == "3")
            {
                break;
            }

            system("cls");
            cout << "Wpisz zakres międzu 1 a 3," << endl;

        }

        if (SelectedOption == "1")
        {
            //Wypisywanie plików z pliku
            system("cls");
            fin.close();
            Towary->StertaStarychSavow();
        }
        else if (SelectedOption == "2")
        {
            //Wpisz ponownie nazwę pliku 
            system("cls");
            fin.close();
            Towary->StaraSesja();
        }
        else if (SelectedOption == "3")
        {
            //Powrót ponownie do menu
            system("cls");
            fin.close();
            Towary->StartMenu();
        }
    }
    else
    {
        //Udało się otworzyć plik 
        Towary->FileName = lFileName;
        Towary->NewSession = false;


        fin.close();
        system("cls");
        Towary->InMenu();
    }
}

void Program::StertaStarychSavow()
{
    for (;;)
    {
        cout << "Wybierz nazwę sava :" << endl;
        int Selected = 0;
        int IleSavow = 0; 
        string last = "";
        string line = "";
        ifstream File("Helper");

        for (;;)
        {
            getline(File, line);

            if (last == "" && line == "")
            {
                break;
            }
            last = line;
            IleSavow = IleSavow + 1;
        }

        string*Tab;
        Tab = new string[IleSavow];

        IleSavow = IleSavow - 1;
        File.close();
        
        ifstream FileV2("Helper");
        for (int i = 0; i < IleSavow; i++)
        {
            getline(FileV2, line);

            Tab[i] = line;
            cout << i + 1 << ". " << line << endl;
        }
        cin >> Selected;
        if (Selected < IleSavow + 1 && Selected > 0)
        {
            Towary->FileName = Tab[Selected - 1];
            Towary->InMenu();
            break;
        }
        else
        {
            cout << "Spróbuj ponownie, wybierz zakres niędzy 1, a " <<IleSavow << endl;
        }
    }

}

string Program::GetUserName()
{
    string UserName = "";

    string last = "";
    string line = "";
    ifstream File(Towary->FileName);
    for (;;)
    {
        getline(File, line);

        if (line == "[USER]")
        {
            getline(File, line);
            UserName = line;
            break;
        }
    }
    Towary->UserName = UserName;
    return UserName;
}

void Program::InMenu()
{
    Towary->GetUserName();
    string SelectedIndex;
    if (Towary->NewSession)
    {
        cout << "Witaj, " << Towary->UserName << ", oto program magazynierski, w czym mogę pomóc ? " << endl;
    }
    else
    {
        cout << "Witaj ponownie " << Towary->UserName << " w czym mogę pomóc ?" << endl;
    }

    Towary->NewSession = false;

    for (;;)
    {
        cout << "1. Dodaj produkt" << endl;
        cout << "2. Usun produkt" << endl;
        cout << "3. Wyswietl produkty" << endl;
        cin >> SelectedIndex;

        if (SelectedIndex == "1" || SelectedIndex == "2" || SelectedIndex == "3")
        {
            break;
        }
        else
        {
            cout << "Podaj poprawny zakres między 1 a 3" << endl;
        }
    }
    
    if (SelectedIndex == "1")
    {
        //Dodaj produkt
        system("cls");
        Towary->DodajProdukt();
    }
    else if (SelectedIndex == "2")
    {
        //Usun produkt
        system("cls");
        Towary->UsunProdukt();
    }
    else if (SelectedIndex == "3")
    {
        //Wyswietl produkt
        system("cls");
        Towary->WyswietlProdukty(true);
    }
}
