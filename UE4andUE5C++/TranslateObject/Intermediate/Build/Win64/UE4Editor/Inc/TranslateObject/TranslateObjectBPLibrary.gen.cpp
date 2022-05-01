// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "TranslateObject/Public/TranslateObjectBPLibrary.h"
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4883)
#endif
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeTranslateObjectBPLibrary() {}
// Cross Module References
	TRANSLATEOBJECT_API UEnum* Z_Construct_UEnum_TranslateObject_Language();
	UPackage* Z_Construct_UPackage__Script_TranslateObject();
	TRANSLATEOBJECT_API UScriptStruct* Z_Construct_UScriptStruct_FOptions();
	TRANSLATEOBJECT_API UScriptStruct* Z_Construct_UScriptStruct_FTranslate();
	TRANSLATEOBJECT_API UClass* Z_Construct_UClass_UTranslateObjectBPLibrary_NoRegister();
	TRANSLATEOBJECT_API UClass* Z_Construct_UClass_UTranslateObjectBPLibrary();
	ENGINE_API UClass* Z_Construct_UClass_UBlueprintFunctionLibrary();
	TRANSLATEOBJECT_API UClass* Z_Construct_UClass_UTranslateData_NoRegister();
	UMG_API UClass* Z_Construct_UClass_UTextBlock_NoRegister();
	TRANSLATEOBJECT_API UClass* Z_Construct_UClass_UTranslateData();
	ENGINE_API UClass* Z_Construct_UClass_UDataAsset();
// End Cross Module References
	static UEnum* Language_StaticEnum()
	{
		static UEnum* Singleton = nullptr;
		if (!Singleton)
		{
			Singleton = GetStaticEnum(Z_Construct_UEnum_TranslateObject_Language, Z_Construct_UPackage__Script_TranslateObject(), TEXT("Language"));
		}
		return Singleton;
	}
	template<> TRANSLATEOBJECT_API UEnum* StaticEnum<Language>()
	{
		return Language_StaticEnum();
	}
	static FCompiledInDeferEnum Z_CompiledInDeferEnum_UEnum_Language(Language_StaticEnum, TEXT("/Script/TranslateObject"), TEXT("Language"), false, nullptr, nullptr);
	uint32 Get_Z_Construct_UEnum_TranslateObject_Language_Hash() { return 3127167889U; }
	UEnum* Z_Construct_UEnum_TranslateObject_Language()
	{
#if WITH_HOT_RELOAD
		UPackage* Outer = Z_Construct_UPackage__Script_TranslateObject();
		static UEnum* ReturnEnum = FindExistingEnumIfHotReloadOrDynamic(Outer, TEXT("Language"), 0, Get_Z_Construct_UEnum_TranslateObject_Language_Hash(), false);
#else
		static UEnum* ReturnEnum = nullptr;
#endif // WITH_HOT_RELOAD
		if (!ReturnEnum)
		{
			static const UE4CodeGen_Private::FEnumeratorParam Enumerators[] = {
				{ "Polish", (int64)Polish },
				{ "English", (int64)English },
			};
#if WITH_METADATA
			const UE4CodeGen_Private::FMetaDataPairParam Enum_MetaDataParams[] = {
				{ "English.DisplayName", "English" },
				{ "English.Name", "English" },
				{ "ModuleRelativePath", "Public/TranslateObjectBPLibrary.h" },
				{ "Polish.DisplayName", "Polish" },
				{ "Polish.Name", "Polish" },
			};
#endif
			static const UE4CodeGen_Private::FEnumParams EnumParams = {
				(UObject*(*)())Z_Construct_UPackage__Script_TranslateObject,
				nullptr,
				"Language",
				"Language",
				Enumerators,
				UE_ARRAY_COUNT(Enumerators),
				RF_Public|RF_Transient|RF_MarkAsNative,
				EEnumFlags::None,
				UE4CodeGen_Private::EDynamicType::NotDynamic,
				(uint8)UEnum::ECppForm::Regular,
				METADATA_PARAMS(Enum_MetaDataParams, UE_ARRAY_COUNT(Enum_MetaDataParams))
			};
			UE4CodeGen_Private::ConstructUEnum(ReturnEnum, EnumParams);
		}
		return ReturnEnum;
	}
class UScriptStruct* FOptions::StaticStruct()
{
	static class UScriptStruct* Singleton = NULL;
	if (!Singleton)
	{
		extern TRANSLATEOBJECT_API uint32 Get_Z_Construct_UScriptStruct_FOptions_Hash();
		Singleton = GetStaticStruct(Z_Construct_UScriptStruct_FOptions, Z_Construct_UPackage__Script_TranslateObject(), TEXT("Options"), sizeof(FOptions), Get_Z_Construct_UScriptStruct_FOptions_Hash());
	}
	return Singleton;
}
template<> TRANSLATEOBJECT_API UScriptStruct* StaticStruct<FOptions>()
{
	return FOptions::StaticStruct();
}
static FCompiledInDeferStruct Z_CompiledInDeferStruct_UScriptStruct_FOptions(FOptions::StaticStruct, TEXT("/Script/TranslateObject"), TEXT("Options"), false, nullptr, nullptr);
static struct FScriptStruct_TranslateObject_StaticRegisterNativesFOptions
{
	FScriptStruct_TranslateObject_StaticRegisterNativesFOptions()
	{
		UScriptStruct::DeferCppStructOps<FOptions>(FName(TEXT("Options")));
	}
} ScriptStruct_TranslateObject_StaticRegisterNativesFOptions;
	struct Z_Construct_UScriptStruct_FOptions_Statics
	{
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Struct_MetaDataParams[];
#endif
		static void* NewStructOps();
		static const UE4CodeGen_Private::FStructPropertyParams NewProp_Data_Inner;
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_Data_MetaData[];
#endif
		static const UE4CodeGen_Private::FArrayPropertyParams NewProp_Data;
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_Describe_MetaData[];
#endif
		static const UE4CodeGen_Private::FStrPropertyParams NewProp_Describe;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
		static const UE4CodeGen_Private::FStructParams ReturnStructParams;
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UScriptStruct_FOptions_Statics::Struct_MetaDataParams[] = {
		{ "BlueprintType", "true" },
		{ "ModuleRelativePath", "Public/TranslateObjectBPLibrary.h" },
	};
#endif
	void* Z_Construct_UScriptStruct_FOptions_Statics::NewStructOps()
	{
		return (UScriptStruct::ICppStructOps*)new UScriptStruct::TCppStructOps<FOptions>();
	}
	const UE4CodeGen_Private::FStructPropertyParams Z_Construct_UScriptStruct_FOptions_Statics::NewProp_Data_Inner = { "Data", nullptr, (EPropertyFlags)0x0000000000000000, UE4CodeGen_Private::EPropertyGenFlags::Struct, RF_Public|RF_Transient|RF_MarkAsNative, 1, 0, Z_Construct_UScriptStruct_FTranslate, METADATA_PARAMS(nullptr, 0) };
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UScriptStruct_FOptions_Statics::NewProp_Data_MetaData[] = {
		{ "Category", "Translate text" },
		{ "ModuleRelativePath", "Public/TranslateObjectBPLibrary.h" },
	};
#endif
	const UE4CodeGen_Private::FArrayPropertyParams Z_Construct_UScriptStruct_FOptions_Statics::NewProp_Data = { "Data", nullptr, (EPropertyFlags)0x0010000000000005, UE4CodeGen_Private::EPropertyGenFlags::Array, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(FOptions, Data), EArrayPropertyFlags::None, METADATA_PARAMS(Z_Construct_UScriptStruct_FOptions_Statics::NewProp_Data_MetaData, UE_ARRAY_COUNT(Z_Construct_UScriptStruct_FOptions_Statics::NewProp_Data_MetaData)) };
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UScriptStruct_FOptions_Statics::NewProp_Describe_MetaData[] = {
		{ "Category", "Describe" },
		{ "ModuleRelativePath", "Public/TranslateObjectBPLibrary.h" },
	};
#endif
	const UE4CodeGen_Private::FStrPropertyParams Z_Construct_UScriptStruct_FOptions_Statics::NewProp_Describe = { "Describe", nullptr, (EPropertyFlags)0x0010000000000005, UE4CodeGen_Private::EPropertyGenFlags::Str, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(FOptions, Describe), METADATA_PARAMS(Z_Construct_UScriptStruct_FOptions_Statics::NewProp_Describe_MetaData, UE_ARRAY_COUNT(Z_Construct_UScriptStruct_FOptions_Statics::NewProp_Describe_MetaData)) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UScriptStruct_FOptions_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UScriptStruct_FOptions_Statics::NewProp_Data_Inner,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UScriptStruct_FOptions_Statics::NewProp_Data,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UScriptStruct_FOptions_Statics::NewProp_Describe,
	};
	const UE4CodeGen_Private::FStructParams Z_Construct_UScriptStruct_FOptions_Statics::ReturnStructParams = {
		(UObject* (*)())Z_Construct_UPackage__Script_TranslateObject,
		nullptr,
		&NewStructOps,
		"Options",
		sizeof(FOptions),
		alignof(FOptions),
		Z_Construct_UScriptStruct_FOptions_Statics::PropPointers,
		UE_ARRAY_COUNT(Z_Construct_UScriptStruct_FOptions_Statics::PropPointers),
		RF_Public|RF_Transient|RF_MarkAsNative,
		EStructFlags(0x00000001),
		METADATA_PARAMS(Z_Construct_UScriptStruct_FOptions_Statics::Struct_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UScriptStruct_FOptions_Statics::Struct_MetaDataParams))
	};
	UScriptStruct* Z_Construct_UScriptStruct_FOptions()
	{
#if WITH_HOT_RELOAD
		extern uint32 Get_Z_Construct_UScriptStruct_FOptions_Hash();
		UPackage* Outer = Z_Construct_UPackage__Script_TranslateObject();
		static UScriptStruct* ReturnStruct = FindExistingStructIfHotReloadOrDynamic(Outer, TEXT("Options"), sizeof(FOptions), Get_Z_Construct_UScriptStruct_FOptions_Hash(), false);
#else
		static UScriptStruct* ReturnStruct = nullptr;
#endif
		if (!ReturnStruct)
		{
			UE4CodeGen_Private::ConstructUScriptStruct(ReturnStruct, Z_Construct_UScriptStruct_FOptions_Statics::ReturnStructParams);
		}
		return ReturnStruct;
	}
	uint32 Get_Z_Construct_UScriptStruct_FOptions_Hash() { return 2890393086U; }
class UScriptStruct* FTranslate::StaticStruct()
{
	static class UScriptStruct* Singleton = NULL;
	if (!Singleton)
	{
		extern TRANSLATEOBJECT_API uint32 Get_Z_Construct_UScriptStruct_FTranslate_Hash();
		Singleton = GetStaticStruct(Z_Construct_UScriptStruct_FTranslate, Z_Construct_UPackage__Script_TranslateObject(), TEXT("Translate"), sizeof(FTranslate), Get_Z_Construct_UScriptStruct_FTranslate_Hash());
	}
	return Singleton;
}
template<> TRANSLATEOBJECT_API UScriptStruct* StaticStruct<FTranslate>()
{
	return FTranslate::StaticStruct();
}
static FCompiledInDeferStruct Z_CompiledInDeferStruct_UScriptStruct_FTranslate(FTranslate::StaticStruct, TEXT("/Script/TranslateObject"), TEXT("Translate"), false, nullptr, nullptr);
static struct FScriptStruct_TranslateObject_StaticRegisterNativesFTranslate
{
	FScriptStruct_TranslateObject_StaticRegisterNativesFTranslate()
	{
		UScriptStruct::DeferCppStructOps<FTranslate>(FName(TEXT("Translate")));
	}
} ScriptStruct_TranslateObject_StaticRegisterNativesFTranslate;
	struct Z_Construct_UScriptStruct_FTranslate_Statics
	{
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Struct_MetaDataParams[];
#endif
		static void* NewStructOps();
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_Data_MetaData[];
#endif
		static const UE4CodeGen_Private::FStrPropertyParams NewProp_Data;
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_Language_MetaData[];
#endif
		static const UE4CodeGen_Private::FBytePropertyParams NewProp_Language;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
		static const UE4CodeGen_Private::FStructParams ReturnStructParams;
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UScriptStruct_FTranslate_Statics::Struct_MetaDataParams[] = {
		{ "BlueprintType", "true" },
		{ "ModuleRelativePath", "Public/TranslateObjectBPLibrary.h" },
	};
#endif
	void* Z_Construct_UScriptStruct_FTranslate_Statics::NewStructOps()
	{
		return (UScriptStruct::ICppStructOps*)new UScriptStruct::TCppStructOps<FTranslate>();
	}
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UScriptStruct_FTranslate_Statics::NewProp_Data_MetaData[] = {
		{ "Category", "Translate text" },
		{ "ModuleRelativePath", "Public/TranslateObjectBPLibrary.h" },
	};
#endif
	const UE4CodeGen_Private::FStrPropertyParams Z_Construct_UScriptStruct_FTranslate_Statics::NewProp_Data = { "Data", nullptr, (EPropertyFlags)0x0010000000000005, UE4CodeGen_Private::EPropertyGenFlags::Str, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(FTranslate, Data), METADATA_PARAMS(Z_Construct_UScriptStruct_FTranslate_Statics::NewProp_Data_MetaData, UE_ARRAY_COUNT(Z_Construct_UScriptStruct_FTranslate_Statics::NewProp_Data_MetaData)) };
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UScriptStruct_FTranslate_Statics::NewProp_Language_MetaData[] = {
		{ "Category", "Translate text" },
		{ "ModuleRelativePath", "Public/TranslateObjectBPLibrary.h" },
	};
#endif
	const UE4CodeGen_Private::FBytePropertyParams Z_Construct_UScriptStruct_FTranslate_Statics::NewProp_Language = { "Language", nullptr, (EPropertyFlags)0x0010000000000005, UE4CodeGen_Private::EPropertyGenFlags::Byte, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(FTranslate, Language), Z_Construct_UEnum_TranslateObject_Language, METADATA_PARAMS(Z_Construct_UScriptStruct_FTranslate_Statics::NewProp_Language_MetaData, UE_ARRAY_COUNT(Z_Construct_UScriptStruct_FTranslate_Statics::NewProp_Language_MetaData)) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UScriptStruct_FTranslate_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UScriptStruct_FTranslate_Statics::NewProp_Data,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UScriptStruct_FTranslate_Statics::NewProp_Language,
	};
	const UE4CodeGen_Private::FStructParams Z_Construct_UScriptStruct_FTranslate_Statics::ReturnStructParams = {
		(UObject* (*)())Z_Construct_UPackage__Script_TranslateObject,
		nullptr,
		&NewStructOps,
		"Translate",
		sizeof(FTranslate),
		alignof(FTranslate),
		Z_Construct_UScriptStruct_FTranslate_Statics::PropPointers,
		UE_ARRAY_COUNT(Z_Construct_UScriptStruct_FTranslate_Statics::PropPointers),
		RF_Public|RF_Transient|RF_MarkAsNative,
		EStructFlags(0x00000001),
		METADATA_PARAMS(Z_Construct_UScriptStruct_FTranslate_Statics::Struct_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UScriptStruct_FTranslate_Statics::Struct_MetaDataParams))
	};
	UScriptStruct* Z_Construct_UScriptStruct_FTranslate()
	{
#if WITH_HOT_RELOAD
		extern uint32 Get_Z_Construct_UScriptStruct_FTranslate_Hash();
		UPackage* Outer = Z_Construct_UPackage__Script_TranslateObject();
		static UScriptStruct* ReturnStruct = FindExistingStructIfHotReloadOrDynamic(Outer, TEXT("Translate"), sizeof(FTranslate), Get_Z_Construct_UScriptStruct_FTranslate_Hash(), false);
#else
		static UScriptStruct* ReturnStruct = nullptr;
#endif
		if (!ReturnStruct)
		{
			UE4CodeGen_Private::ConstructUScriptStruct(ReturnStruct, Z_Construct_UScriptStruct_FTranslate_Statics::ReturnStructParams);
		}
		return ReturnStruct;
	}
	uint32 Get_Z_Construct_UScriptStruct_FTranslate_Hash() { return 147406657U; }
	DEFINE_FUNCTION(UTranslateObjectBPLibrary::execGetText)
	{
		P_GET_OBJECT(UTranslateData,Z_Param_TranslateData);
		P_GET_PROPERTY(FByteProperty,Z_Param_Language);
		P_GET_PROPERTY(FIntProperty,Z_Param_IndexToGet);
		P_GET_PROPERTY_REF(FStrProperty,Z_Param_Out_Out);
		P_FINISH;
		P_NATIVE_BEGIN;
		UTranslateObjectBPLibrary::GetText(Z_Param_TranslateData,Language(Z_Param_Language),Z_Param_IndexToGet,Z_Param_Out_Out);
		P_NATIVE_END;
	}
	DEFINE_FUNCTION(UTranslateObjectBPLibrary::execSetTextToTextBlock)
	{
		P_GET_TARRAY(UTextBlock*,Z_Param_Text);
		P_GET_OBJECT(UTranslateData,Z_Param_TranslateData);
		P_GET_PROPERTY(FByteProperty,Z_Param_Language);
		P_FINISH;
		P_NATIVE_BEGIN;
		UTranslateObjectBPLibrary::SetTextToTextBlock(Z_Param_Text,Z_Param_TranslateData,Language(Z_Param_Language));
		P_NATIVE_END;
	}
	void UTranslateObjectBPLibrary::StaticRegisterNativesUTranslateObjectBPLibrary()
	{
		UClass* Class = UTranslateObjectBPLibrary::StaticClass();
		static const FNameNativePtrPair Funcs[] = {
			{ "GetText", &UTranslateObjectBPLibrary::execGetText },
			{ "SetTextToTextBlock", &UTranslateObjectBPLibrary::execSetTextToTextBlock },
		};
		FNativeFunctionRegistrar::RegisterFunctions(Class, Funcs, UE_ARRAY_COUNT(Funcs));
	}
	struct Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics
	{
		struct TranslateObjectBPLibrary_eventGetText_Parms
		{
			UTranslateData* TranslateData;
			TEnumAsByte<Language> Language;
			int32 IndexToGet;
			FString Out;
		};
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_TranslateData;
		static const UE4CodeGen_Private::FBytePropertyParams NewProp_Language;
		static const UE4CodeGen_Private::FUnsizedIntPropertyParams NewProp_IndexToGet;
		static const UE4CodeGen_Private::FStrPropertyParams NewProp_Out;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics::NewProp_TranslateData = { "TranslateData", nullptr, (EPropertyFlags)0x0010000000000080, UE4CodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(TranslateObjectBPLibrary_eventGetText_Parms, TranslateData), Z_Construct_UClass_UTranslateData_NoRegister, METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FBytePropertyParams Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics::NewProp_Language = { "Language", nullptr, (EPropertyFlags)0x0010000000000080, UE4CodeGen_Private::EPropertyGenFlags::Byte, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(TranslateObjectBPLibrary_eventGetText_Parms, Language), Z_Construct_UEnum_TranslateObject_Language, METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FUnsizedIntPropertyParams Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics::NewProp_IndexToGet = { "IndexToGet", nullptr, (EPropertyFlags)0x0010000000000080, UE4CodeGen_Private::EPropertyGenFlags::Int, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(TranslateObjectBPLibrary_eventGetText_Parms, IndexToGet), METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FStrPropertyParams Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics::NewProp_Out = { "Out", nullptr, (EPropertyFlags)0x0010000000000180, UE4CodeGen_Private::EPropertyGenFlags::Str, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(TranslateObjectBPLibrary_eventGetText_Parms, Out), METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics::NewProp_TranslateData,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics::NewProp_Language,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics::NewProp_IndexToGet,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics::NewProp_Out,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics::Function_MetaDataParams[] = {
		{ "Category", "Translate plugin" },
		{ "DisplayName", "Get text" },
		{ "Keywords", "Show selector" },
		{ "ModuleRelativePath", "Public/TranslateObjectBPLibrary.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UTranslateObjectBPLibrary, nullptr, "GetText", nullptr, nullptr, sizeof(TranslateObjectBPLibrary_eventGetText_Parms), Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04422401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics
	{
		struct TranslateObjectBPLibrary_eventSetTextToTextBlock_Parms
		{
			TArray<UTextBlock*> Text;
			UTranslateData* TranslateData;
			TEnumAsByte<Language> Language;
		};
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_Text_Inner;
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_Text_MetaData[];
#endif
		static const UE4CodeGen_Private::FArrayPropertyParams NewProp_Text;
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_TranslateData;
		static const UE4CodeGen_Private::FBytePropertyParams NewProp_Language;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::NewProp_Text_Inner = { "Text", nullptr, (EPropertyFlags)0x0000000000080000, UE4CodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, 1, 0, Z_Construct_UClass_UTextBlock_NoRegister, METADATA_PARAMS(nullptr, 0) };
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::NewProp_Text_MetaData[] = {
		{ "EditInline", "true" },
	};
#endif
	const UE4CodeGen_Private::FArrayPropertyParams Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::NewProp_Text = { "Text", nullptr, (EPropertyFlags)0x0010008000000080, UE4CodeGen_Private::EPropertyGenFlags::Array, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(TranslateObjectBPLibrary_eventSetTextToTextBlock_Parms, Text), EArrayPropertyFlags::None, METADATA_PARAMS(Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::NewProp_Text_MetaData, UE_ARRAY_COUNT(Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::NewProp_Text_MetaData)) };
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::NewProp_TranslateData = { "TranslateData", nullptr, (EPropertyFlags)0x0010000000000080, UE4CodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(TranslateObjectBPLibrary_eventSetTextToTextBlock_Parms, TranslateData), Z_Construct_UClass_UTranslateData_NoRegister, METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FBytePropertyParams Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::NewProp_Language = { "Language", nullptr, (EPropertyFlags)0x0010000000000080, UE4CodeGen_Private::EPropertyGenFlags::Byte, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(TranslateObjectBPLibrary_eventSetTextToTextBlock_Parms, Language), Z_Construct_UEnum_TranslateObject_Language, METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::NewProp_Text_Inner,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::NewProp_Text,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::NewProp_TranslateData,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::NewProp_Language,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::Function_MetaDataParams[] = {
		{ "Category", "Translate plugin" },
		{ "DisplayName", "Text changer" },
		{ "Keywords", "Show selector" },
		{ "ModuleRelativePath", "Public/TranslateObjectBPLibrary.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UTranslateObjectBPLibrary, nullptr, "SetTextToTextBlock", nullptr, nullptr, sizeof(TranslateObjectBPLibrary_eventSetTextToTextBlock_Parms), Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04022401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	UClass* Z_Construct_UClass_UTranslateObjectBPLibrary_NoRegister()
	{
		return UTranslateObjectBPLibrary::StaticClass();
	}
	struct Z_Construct_UClass_UTranslateObjectBPLibrary_Statics
	{
		static UObject* (*const DependentSingletons[])();
		static const FClassFunctionLinkInfo FuncInfo[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Class_MetaDataParams[];
#endif
		static const FCppClassTypeInfoStatic StaticCppClassTypeInfo;
		static const UE4CodeGen_Private::FClassParams ClassParams;
	};
	UObject* (*const Z_Construct_UClass_UTranslateObjectBPLibrary_Statics::DependentSingletons[])() = {
		(UObject* (*)())Z_Construct_UClass_UBlueprintFunctionLibrary,
		(UObject* (*)())Z_Construct_UPackage__Script_TranslateObject,
	};
	const FClassFunctionLinkInfo Z_Construct_UClass_UTranslateObjectBPLibrary_Statics::FuncInfo[] = {
		{ &Z_Construct_UFunction_UTranslateObjectBPLibrary_GetText, "GetText" }, // 4251326268
		{ &Z_Construct_UFunction_UTranslateObjectBPLibrary_SetTextToTextBlock, "SetTextToTextBlock" }, // 3198007918
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UTranslateObjectBPLibrary_Statics::Class_MetaDataParams[] = {
		{ "IncludePath", "TranslateObjectBPLibrary.h" },
		{ "ModuleRelativePath", "Public/TranslateObjectBPLibrary.h" },
	};
#endif
	const FCppClassTypeInfoStatic Z_Construct_UClass_UTranslateObjectBPLibrary_Statics::StaticCppClassTypeInfo = {
		TCppClassTypeTraits<UTranslateObjectBPLibrary>::IsAbstract,
	};
	const UE4CodeGen_Private::FClassParams Z_Construct_UClass_UTranslateObjectBPLibrary_Statics::ClassParams = {
		&UTranslateObjectBPLibrary::StaticClass,
		nullptr,
		&StaticCppClassTypeInfo,
		DependentSingletons,
		FuncInfo,
		nullptr,
		nullptr,
		UE_ARRAY_COUNT(DependentSingletons),
		UE_ARRAY_COUNT(FuncInfo),
		0,
		0,
		0x000000A0u,
		METADATA_PARAMS(Z_Construct_UClass_UTranslateObjectBPLibrary_Statics::Class_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UClass_UTranslateObjectBPLibrary_Statics::Class_MetaDataParams))
	};
	UClass* Z_Construct_UClass_UTranslateObjectBPLibrary()
	{
		static UClass* OuterClass = nullptr;
		if (!OuterClass)
		{
			UE4CodeGen_Private::ConstructUClass(OuterClass, Z_Construct_UClass_UTranslateObjectBPLibrary_Statics::ClassParams);
		}
		return OuterClass;
	}
	IMPLEMENT_CLASS(UTranslateObjectBPLibrary, 3460765031);
	template<> TRANSLATEOBJECT_API UClass* StaticClass<UTranslateObjectBPLibrary>()
	{
		return UTranslateObjectBPLibrary::StaticClass();
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_UTranslateObjectBPLibrary(Z_Construct_UClass_UTranslateObjectBPLibrary, &UTranslateObjectBPLibrary::StaticClass, TEXT("/Script/TranslateObject"), TEXT("UTranslateObjectBPLibrary"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(UTranslateObjectBPLibrary);
	void UTranslateData::StaticRegisterNativesUTranslateData()
	{
	}
	UClass* Z_Construct_UClass_UTranslateData_NoRegister()
	{
		return UTranslateData::StaticClass();
	}
	struct Z_Construct_UClass_UTranslateData_Statics
	{
		static UObject* (*const DependentSingletons[])();
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Class_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FStructPropertyParams NewProp_Translated_Inner;
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_Translated_MetaData[];
#endif
		static const UE4CodeGen_Private::FArrayPropertyParams NewProp_Translated;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
		static const FCppClassTypeInfoStatic StaticCppClassTypeInfo;
		static const UE4CodeGen_Private::FClassParams ClassParams;
	};
	UObject* (*const Z_Construct_UClass_UTranslateData_Statics::DependentSingletons[])() = {
		(UObject* (*)())Z_Construct_UClass_UDataAsset,
		(UObject* (*)())Z_Construct_UPackage__Script_TranslateObject,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UTranslateData_Statics::Class_MetaDataParams[] = {
		{ "Comment", "/////////////////////////////////////////////////////\n//\n// Klasa\n// \n// Zawarto?? :\n// Struktury FOptions \n// \n// TRANSLATE INFO\n// 0 = Polish \n// 1 = English \n// 2 = Germany \n// \n/////////////////////////////////////////////////////\n" },
		{ "IncludePath", "TranslateObjectBPLibrary.h" },
		{ "ModuleRelativePath", "Public/TranslateObjectBPLibrary.h" },
		{ "ToolTip", "Klasa\n\nZawarto?? :\nStruktury FOptions\n\nTRANSLATE INFO\n0 = Polish\n1 = English\n2 = Germany" },
	};
#endif
	const UE4CodeGen_Private::FStructPropertyParams Z_Construct_UClass_UTranslateData_Statics::NewProp_Translated_Inner = { "Translated", nullptr, (EPropertyFlags)0x0000000000000000, UE4CodeGen_Private::EPropertyGenFlags::Struct, RF_Public|RF_Transient|RF_MarkAsNative, 1, 0, Z_Construct_UScriptStruct_FOptions, METADATA_PARAMS(nullptr, 0) };
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UTranslateData_Statics::NewProp_Translated_MetaData[] = {
		{ "Category", "Data translate" },
		{ "ModuleRelativePath", "Public/TranslateObjectBPLibrary.h" },
	};
#endif
	const UE4CodeGen_Private::FArrayPropertyParams Z_Construct_UClass_UTranslateData_Statics::NewProp_Translated = { "Translated", nullptr, (EPropertyFlags)0x0010000000000005, UE4CodeGen_Private::EPropertyGenFlags::Array, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(UTranslateData, Translated), EArrayPropertyFlags::None, METADATA_PARAMS(Z_Construct_UClass_UTranslateData_Statics::NewProp_Translated_MetaData, UE_ARRAY_COUNT(Z_Construct_UClass_UTranslateData_Statics::NewProp_Translated_MetaData)) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UClass_UTranslateData_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_UTranslateData_Statics::NewProp_Translated_Inner,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_UTranslateData_Statics::NewProp_Translated,
	};
	const FCppClassTypeInfoStatic Z_Construct_UClass_UTranslateData_Statics::StaticCppClassTypeInfo = {
		TCppClassTypeTraits<UTranslateData>::IsAbstract,
	};
	const UE4CodeGen_Private::FClassParams Z_Construct_UClass_UTranslateData_Statics::ClassParams = {
		&UTranslateData::StaticClass,
		nullptr,
		&StaticCppClassTypeInfo,
		DependentSingletons,
		nullptr,
		Z_Construct_UClass_UTranslateData_Statics::PropPointers,
		nullptr,
		UE_ARRAY_COUNT(DependentSingletons),
		0,
		UE_ARRAY_COUNT(Z_Construct_UClass_UTranslateData_Statics::PropPointers),
		0,
		0x000000A0u,
		METADATA_PARAMS(Z_Construct_UClass_UTranslateData_Statics::Class_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UClass_UTranslateData_Statics::Class_MetaDataParams))
	};
	UClass* Z_Construct_UClass_UTranslateData()
	{
		static UClass* OuterClass = nullptr;
		if (!OuterClass)
		{
			UE4CodeGen_Private::ConstructUClass(OuterClass, Z_Construct_UClass_UTranslateData_Statics::ClassParams);
		}
		return OuterClass;
	}
	IMPLEMENT_CLASS(UTranslateData, 3207424320);
	template<> TRANSLATEOBJECT_API UClass* StaticClass<UTranslateData>()
	{
		return UTranslateData::StaticClass();
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_UTranslateData(Z_Construct_UClass_UTranslateData, &UTranslateData::StaticClass, TEXT("/Script/TranslateObject"), TEXT("UTranslateData"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(UTranslateData);
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
