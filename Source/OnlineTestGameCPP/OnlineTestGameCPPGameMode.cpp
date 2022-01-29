// Copyright Epic Games, Inc. All Rights Reserved.

#include "OnlineTestGameCPPGameMode.h"
#include "OnlineTestGameCPPCharacter.h"
#include "UObject/ConstructorHelpers.h"

AOnlineTestGameCPPGameMode::AOnlineTestGameCPPGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
