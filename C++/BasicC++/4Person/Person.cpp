#include <iostream>
#include <fstream>
#include <string>
using namespace std;

class Person
{
public:

    //Person managment
    void DodajOsobe();
    void UsunOsobe();
    bool WyswietlOsoby(bool ToMenu);
    void StaraSesja();
    void OldSave();
    void SearchForPerson();
    
    //search person
    string GetUserName();

    //Menu func
    void StartMenu();
    void InMenu();

    

    bool NewSession = true;
    string FileName;
    string UserName;
};

Person* Ludzie = new Person;

int main()
{
    setlocale(LC_CTYPE, "Polish");
    Ludzie->StartMenu();
}

void Person::StartMenu()
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
        Ludzie->StaraSesja();
    }
    else if (Selected == "2")
    {
        Ludzie->NewSession = true;
        system("cls");
        cout << "Podaj nazwę użytkownika :" << endl;
        cin >> Ludzie->UserName;

        cout << "Podaj nazwę zapisu :" << endl;
        cin >> Ludzie->FileName;

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

        fout << Ludzie->FileName << endl;
        fout.close();

        string File = Ludzie->FileName;
        ofstream fout2(File.c_str());
        fout2 << "[USER]" << endl;
        fout2 << Ludzie->UserName << endl;
        fout2 << "" << endl;
        fout2.close();

        system("cls");
        Ludzie->InMenu();
    }
}

void Person::DodajOsobe()
{
    string File = Ludzie->FileName;

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


    string Name = "";
    int PersonIndex = 0;
    string Surename = "";
    int Age = 0;
    bool PersonActive = true;

    cout << "Name :" << endl;
    cin >> Name;

    cout << "Surename :" << endl;
    cin >> Surename;

    cout << "Age" << endl;
    cin >> Age;

    fout << "[PA]" << endl;
    fout << PersonActive << endl;

    fout << "[PI]" << endl;
    fout << PersonIndex << endl;

    fout << "[PN]" << endl;
    fout << Name << endl;

    fout << "[PQ]" << endl;
    fout << Surename << endl;

    fout << "[PP]" << endl;
    fout << Age << endl;

    fout << "" << endl;

    fout.close();

    system("cls");

    Ludzie->InMenu();
}

void Person::UsunOsobe()
{
    if (Ludzie->WyswietlOsoby(false))
    {
        cout << "Wpisz element do usunięcia" << endl;
        int indexToDelete = 0;
        cin >> indexToDelete;

        string last = "";
        string line = "";
        ifstream File(Ludzie->FileName);
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

        ifstream FileV2(Ludzie->FileName);

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

        string filetosave = Ludzie->FileName;
        ofstream fout(filetosave.c_str());

        for (int i = 0; i < HowManyLines; i++)
        {
            fout << Tab[i] << endl;
        }

        system("cls");

        cout << "Pomyślnie usunięto osobę" << endl;

    }
    Ludzie->InMenu();
}

bool Person::WyswietlOsoby(bool ToMenu)
{
    string last = "";
    string line = "";
    ifstream File(Ludzie->FileName);

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
                cout << "Osoba nr " << index + 1 << " name : " << line << endl;
            }
        }
        else if (line == "[PQ]")
        {
            if (PrintInfo)
            {
                getline(File, line);
                cout << "Osoba nr " << index + 1 << " surename : " << line << endl;
            }
        }
        else if (line == "[PP]")
        {
            if (PrintInfo)
            {
                getline(File, line);
                cout << "Osoba nr " << index + 1 << " age : " << stold(line) << endl;

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
        cout << "Niestety nie znaleźliśmy żadnej osoby" << endl;
    }
    if (ToMenu)
    {
        Ludzie->InMenu();
    }

    return Foundedany;
}

void Person::StaraSesja()
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
            cout << "Wpisałeś/aś nie poprawną nazwę pliku, wybierz opcję :" << endl;
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
            Ludzie->OldSave();
        }
        else if (SelectedOption == "2")
        {
            //Wpisz ponownie nazwę pliku 
            system("cls");
            fin.close();
            Ludzie->StaraSesja();
        }
        else if (SelectedOption == "3")
        {
            //Powrót ponownie do menu
            system("cls");
            fin.close();
            Ludzie->StartMenu();
        }
    }
    else
    {
        //Udało się otworzyć plik 
        Ludzie->FileName = lFileName;
        Ludzie->NewSession = false;


        fin.close();
        system("cls");
        Ludzie->InMenu();
    }
}

void Person::OldSave()
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

        string* Tab;
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
            Ludzie->FileName = Tab[Selected - 1];
            Ludzie->InMenu();
            break;
        }
        else
        {
            cout << "Spróbuj ponownie, wybierz zakres między 1, a " << IleSavow << endl;
        }
    }

}

void Person::SearchForPerson()
{
    string SurrnameSearch;

    cout << "Podaj nazwisko :" << endl;
    cin >> SurrnameSearch;
    ifstream File(Ludzie->FileName);
    int index = 0;
    int HowManyLines = 0;
    int lineNumber = 0;
    string last = "";
    string line = "";

    string lastPN = "";
    string Age = "";
    string lastSurname = "";

    for (;;)
    {
        getline(File, line);

        if (SurrnameSearch == last)
        {
            getline(File, line);

            cout << index << ". " << lastPN << " " << lastSurname << " wiek = " << line << endl;
            Ludzie->InMenu();
            break;
        }

        if (last == "" && line == "")
        {
            cout << "Niestety nie znalezmy uzytkownika" << endl;
            Ludzie->InMenu();
            break;
        }

        if (line == "[PN]")
        {
            index = index + 1;
            getline(File, line);
            lastPN = line;  

        }

        if (line == "[PP]")
        {
            getline(File, line);
            Age = line;

        }

        if (line == "[PQ]")
        {
            getline(File, line);
            lastSurname = line;

        }

        
        last = line;
        HowManyLines = HowManyLines + 1;

    }

    File.close();
}

string Person::GetUserName()
{
    string UserName = "";

    string last = "";
    string line = "";
    ifstream File(Ludzie->FileName);
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
    Ludzie->UserName = UserName;
    return UserName;
}

void Person::InMenu()
{
    Ludzie->GetUserName();
    string SelectedIndex;
    if (Ludzie->NewSession)
    {
        cout << "Witaj, " << Ludzie->UserName << ", oto program do zarządzania danymi osób, w czym mogę pomóc ? " << endl;
    }
    else
    {
        cout << "Witaj ponownie " << Ludzie->UserName << " w czym mogę pomóc ?" << endl;
    }

    Ludzie->NewSession = false;

    for (;;)
    {
        cout << "1. Dodaj osobę" << endl;
        cout << "2. Usun osobę" << endl;
        cout << "3. Wyswietl osoby" << endl;
        cout << "4. Wyszukaj po nazwisku" << endl;

        cin >> SelectedIndex;

        if (SelectedIndex == "1" || SelectedIndex == "2" || SelectedIndex == "3" || SelectedIndex == "4")
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
        //Dodaj osobe
        system("cls");
        Ludzie->DodajOsobe();
    }
    else if (SelectedIndex == "2")
    {
        //Usun osobe
        system("cls");
        Ludzie->UsunOsobe();
    }
    else if (SelectedIndex == "3")
    {
        //Wyswietl osoby
        system("cls");
        Ludzie->WyswietlOsoby(true);
    }
    else if (SelectedIndex == "4")
    {
        //Szukaj osoby
        system("cls");
        Ludzie->SearchForPerson();
    }
}