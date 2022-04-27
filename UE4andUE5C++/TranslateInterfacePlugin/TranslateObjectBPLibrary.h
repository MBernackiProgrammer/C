#pragma once

#include "Kismet/BlueprintFunctionLibrary.h"
#include "TranslateObjectBPLibrary.generated.h"

UENUM()
enum Language
{
	Polish UMETA(DisplayName = "Polish"),
	English UMETA(DisplayName = "English"),
	//Deutsch UMETA(DisplayName = "Deutsch"),
	//French UMETA(DisplayName = "French")
};

UCLASS()
class UTranslateObjectBPLibrary : public UBlueprintFunctionLibrary
{
	GENERATED_UCLASS_BODY()

	UFUNCTION(BlueprintCallable, meta = (DisplayName = "Text changer", Keywords = "Show selector"), Category = "Translate plugin")
	static void SetTextToTextBlock(TArray<class UTextBlock*>Text, UTranslateData* TranslateData, TEnumAsByte<Language> Language);

	UFUNCTION(BlueprintCallable, meta = (DisplayName = "Get text", Keywords = "Show selector"), Category = "Translate plugin")
	static void GetText(UTranslateData* TranslateData, TEnumAsByte<Language> Language, int IndexToGet, FString &Out);
};


USTRUCT(BlueprintType)
struct FTranslate
{
	GENERATED_BODY()
		UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Translate text")
		FString Data;
	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Translate text")
		TEnumAsByte<Language>Language;
};

USTRUCT(BlueprintType)
struct FOptions
{
	GENERATED_BODY()
	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Translate text")
		TArray<FTranslate> Data;
	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Describe")
		FString Describe;

};

/////////////////////////////////////////////////////
//
// Klasa
// 
// Zawartość :
// Struktury FOptions 
// 
// TRANSLATE INFO
// 0 = Polish 
// 1 = English 
// 2 = Germany 
// 
/////////////////////////////////////////////////////

UCLASS()
class UTranslateData: public UDataAsset
{
	GENERATED_BODY()
public:
	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Data translate")
		TArray<FOptions> Translated;
};
