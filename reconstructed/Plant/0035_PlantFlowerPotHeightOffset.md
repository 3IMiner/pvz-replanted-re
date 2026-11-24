# System.Single PlantFlowerPotHeightOffset(Reloaded.Gameplay.SeedType theSeedType, System.Single theFlowerPotScale)

- 类：`Plant`
- 汇编行数：123

## 反汇编

```asm

Disassembly:
	movss xmm0,dword ptr [183C33F28h]
	movaps xmm3,xmm1
	mulss xmm3,xmm0
	xorps xmm2,xmm2
	cmp ecx,6
	je near ptr 00000001806B3874h
	cmp ecx,19h
	je near ptr 00000001806B3874h
	cmp ecx,0Dh
	je short 00000001806B3862h
	cmp ecx,9
	je short 00000001806B3858h
	cmp ecx,8
	je short 00000001806B3858h
	cmp ecx,0Ch
	je short 00000001806B386Ah
	cmp ecx,1Fh
	je short 00000001806B386Ah
	cmp ecx,34h
	ja short 00000001806B3812h
	mov rdx,100000000400A3h
	bt rdx,rcx
	jb short 00000001806B386Ah
	cmp ecx,26h
	je short 00000001806B386Ah
	cmp ecx,20h
	je short 00000001806B386Ah
	cmp ecx,27h
	je short 00000001806B386Ah
	cmp ecx,13h
	je short 00000001806B386Ah
	cmp ecx,1Bh
	je short 00000001806B386Ah
	cmp ecx,15h
	je short 00000001806B386Ah
	cmp ecx,18h
	je short 00000001806B3858h
	cmp ecx,4
	je short 00000001806B3858h
	cmp ecx,10h
	je short 00000001806B384Eh
	cmp ecx,23h
	jne short 00000001806B3878h
	movss xmm2,dword ptr [183C33F48h]
	jmp short 00000001806B3878h
	movss xmm2,dword ptr [183C34014h]
	jmp short 00000001806B3878h
	movss xmm2,dword ptr [183C34008h]
	jmp short 00000001806B3878h
	addss xmm3,dword ptr [183C33ED4h]
	movss xmm2,dword ptr [183C33F30h]
	jmp short 00000001806B3878h
	addss xmm3,xmm0
	movaps xmm0,xmm2
	xorps xmm2,[183C33CA0h]
	mulss xmm0,xmm1
	addss xmm0,xmm2
	addss xmm0,xmm3
	ret

ISIL:
	001 Move xmm0, [0x183C33F28]
	002 Move xmm3, xmm1
	003 Multiply xmm3, xmm3, xmm0
	004 Move xmm2, 0
	005 Compare rcx, 6
	006 JumpIfEqual {53}
	007 Compare rcx, 25
	008 JumpIfEqual {53}
	009 Compare rcx, 13
	010 JumpIfEqual {50}
	011 Compare rcx, 9
	012 JumpIfEqual {48}
	013 Compare rcx, 8
	014 JumpIfEqual {48}
	015 Compare rcx, 12
	016 JumpIfEqual {51}
	017 Compare rcx, 31
	018 JumpIfEqual {51}
	019 Compare rcx, 52
	020 JumpIfGreater {24}
	021 Move rdx, 0x100000000400A3
	022 NotImplemented "bt rdx,rcx"
	023 JumpIfLess {51}
	024 Compare rcx, 38
	025 JumpIfEqual {51}
	026 Compare rcx, 32
	027 JumpIfEqual {51}
	028 Compare rcx, 39
	029 JumpIfEqual {51}
	030 Compare rcx, 19
	031 JumpIfEqual {51}
	032 Compare rcx, 27
	033 JumpIfEqual {51}
	034 Compare rcx, 21
	035 JumpIfEqual {51}
	036 Compare rcx, 24
	037 JumpIfEqual {48}
	038 Compare rcx, 4
	039 JumpIfEqual {48}
	040 Compare rcx, 16
	041 JumpIfEqual {46}
	042 Compare rcx, 35
	043 JumpIfNotEqual {54}
	044 Move xmm2, [0x183C33F48]
	045 Goto {54}
	046 Move xmm2, [0x183C34014]
	047 Goto {54}
	048 Move xmm2, [0x183C34008]
	049 Goto {54}
	050 Add xmm3, xmm3, [0x183C33ED4]
	051 Move xmm2, [0x183C33F30]
	052 Goto {54}
	053 Add xmm3, xmm3, xmm0
	054 Move xmm0, xmm2
	055 Xor xmm2, xmm2, [0x183C33CA0]
	056 Multiply xmm0, xmm0, xmm1
	057 Add xmm0, xmm0, xmm2
	058 Add xmm0, xmm0, xmm3
	059 Return xmm0
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
