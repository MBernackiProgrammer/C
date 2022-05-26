// Copyright Epic Games, Inc. All Rights Reserved.

#include "TranslateObjectBPLibrary.h"
#include "TranslateObject.h"
#include "Components/TextBlock.h"

UTranslateObjectBPLibrary::UTranslateObjectBPLibrary(const FObjectInitializer& ObjectInitializer)
: Super(ObjectInitializer)
{

}

void UTranslateObjectBPLibrary::SetTextToTextBlock(TArray<class UTextBlock*> Text, UTranslateData*TranslateData, TEnumAsByte<Language> Language)
{
	
	if (TranslateData != NULL)
	{
			int HowManyText = TranslateData->Translated.Max();

			

			for (int i = 0; i < HowManyText; i++)
			{
				FOptions TEXTTRANSLATE;
				TEXTTRANSLATE = TranslateData->Translated[i];
				int HowManyStructs = TEXTTRANSLATE.Data.Max();

				for (int i2 = 0; i2 < HowManyStructs; i2++)
				{
					FTranslate TranslatedText;

					TranslatedText = TEXTTRANSLATE.Data[i2];
					//int cos = TEXTTRANSLATE.Language;
					if (Language == TranslatedText.Language)
					{
						if (i < Text.Max())
						{
							//char* t1 = "text1";

							//t1 = TCHAR_TO_ANSI(*TranslatedText.Data);

							FText t2 = FText::FromString(TranslatedText.Data);

							
							class UTextBlock* Name = Text[i];
							Name->SetText(t2);

							Text[i] = Name;
						}
						
						break;
					}

				}

			}


	}
	else
	{
		UE_LOG(LogTemp, Warning, TEXT("We can't do it. It's to high number, try lower number or check correctly of your file."));
	}
	
}

void UTranslateObjectBPLibrary::GetText(UTranslateData* TranslateData, TEnumAsByte<Language> Language, int IndexToGet, FString& Out)
{
	
	if (TranslateData != NULL)
	{
		if (TranslateData->Translated.Max() > IndexToGet)
		{
			FOptions TEXTTRANSLATE;
			TEXTTRANSLATE = TranslateData->Translated[IndexToGet];
			int HowManyStructs = TEXTTRANSLATE.Data.Max();

			for (int i = 0; i < HowManyStructs; i++)
			{
				FTranslate TranslatedText;
				TranslatedText = TEXTTRANSLATE.Data[i];
				//int cos = TEXTTRANSLATE.Language;

				if (Language == TranslatedText.Language)
				{
					Out = TranslatedText.Data;

					break;
				}
			}
		}
		else
		{
			UE_LOG(LogTemp, Warning, TEXT("We can't do it. It's to high number, try lower number or check correctly of your file."));
		}
	}
	else
	{
		UE_LOG(LogTemp, Warning, TEXT("We can't do it. It's to high number, try lower number or check correctly of your file."));
	}
	
}
