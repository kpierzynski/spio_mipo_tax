using TaxCalculator;
using TaxCalculator.DataModels;

InputReader inputReader = new InputReader( );

//Funkcja createObjectKoszty, na podstawie argumentu "typ" tworzy i zwraca odpowiedni objekt 
//Argument args przekazywany jest do konstruktora obiektu jako jego parametry
Umowa createObjectKoszty( char typ, params object[] args ) {

    Dictionary<char, Type> typyKosztow = new Dictionary<char, Type> {
        { 'P', typeof(UmowaPraca) },
        { 'Z', typeof(UmowaZlecenie) },
    };

    try {
        Type typKosztow = typyKosztow[ typ ];
        return Activator.CreateInstance( typKosztow, args ) as Umowa;
    } catch (KeyNotFoundException e) {
        //KeyNotFoundException jest rzucany, gdy w słowniku nie znajduje się para (klucz,wartość) o podanym kluczu.
        throw new Exception( "Błędny typ umowy." );
    } catch (Exception e) {
        throw new Exception( "Cannot create instance!" );
    }
}

try {
    InputReaderData userInput = inputReader.ReadInput( );

    Umowa koszt = createObjectKoszty( userInput.typ, userInput.podstawa );

    Writer writer = new Writer( );
    writer.PrezentujKoszty( koszt );

} catch (Exception e) {
    Console.WriteLine( e.Message );
    Console.ReadLine( );

    Environment.Exit( -1 );
}

