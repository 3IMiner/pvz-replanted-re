# Reloaded.Gameplay.DamageRangeFlags GetDamageRangeFlags(Reloaded.Gameplay.PlantWeapon thePlantWeapon)

- 类：`Plant`
- 汇编行数：123

## 反汇编

```asm

Disassembly:
	cmp dword ptr [rcx+70h],1Ah
	je near ptr 00000001806B13A2h
	cmp dword ptr [rcx+70h],2
	je near ptr 00000001806B139Ch
	cmp dword ptr [rcx+70h],14h
	je near ptr 00000001806B139Ch
	cmp dword ptr [rcx+70h],2Fh
	je near ptr 00000001806B139Ch
	cmp dword ptr [rcx+70h],0Fh
	je short 00000001806B139Ch
	cmp dword ptr [rcx+70h],27h
	je short 00000001806B1396h
	cmp dword ptr [rcx+70h],20h
	je short 00000001806B1396h
	cmp dword ptr [rcx+70h],22h
	je short 00000001806B1396h
	cmp dword ptr [rcx+70h],2Ch
	je short 00000001806B1396h
	cmp dword ptr [rcx+70h],4
	je short 00000001806B1390h
	cmp dword ptr [rcx+70h],11h
	je short 00000001806B1396h
	cmp dword ptr [rcx+70h],8
	je short 00000001806B138Ah
	cmp dword ptr [rcx+70h],18h
	je short 00000001806B138Ah
	cmp dword ptr [rcx+70h],0Ah
	je short 00000001806B138Ah
	cmp dword ptr [rcx+70h],2Ah
	je short 00000001806B138Ah
	cmp dword ptr [rcx+70h],6
	je short 00000001806B138Ah
	cmp dword ptr [rcx+70h],2Bh
	je short 00000001806B1384h
	cmp dword ptr [rcx+70h],13h
	je short 00000001806B137Eh
	cmp dword ptr [rcx+70h],32h
	mov eax,11h
	mov edx,1
	cmovne eax,edx
	ret
	mov eax,5
	ret
	mov eax,0Bh
	ret
	mov eax,9
	ret
	mov eax,4Dh
	ret
	mov eax,0Dh
	ret
	mov eax,7Fh
	ret
	xor eax,eax
	cmp edx,1
	setne al
	inc eax
	ret

ISIL:
	001 Compare [rcx+112], 26
	002 JumpIfEqual {56}
	003 Compare [rcx+112], 2
	004 JumpIfEqual {54}
	005 Compare [rcx+112], 20
	006 JumpIfEqual {54}
	007 Compare [rcx+112], 47
	008 JumpIfEqual {54}
	009 Compare [rcx+112], 15
	010 JumpIfEqual {54}
	011 Compare [rcx+112], 39
	012 JumpIfEqual {52}
	013 Compare [rcx+112], 32
	014 JumpIfEqual {52}
	015 Compare [rcx+112], 34
	016 JumpIfEqual {52}
	017 Compare [rcx+112], 44
	018 JumpIfEqual {52}
	019 Compare [rcx+112], 4
	020 JumpIfEqual {50}
	021 Compare [rcx+112], 17
	022 JumpIfEqual {52}
	023 Compare [rcx+112], 8
	024 JumpIfEqual {48}
	025 Compare [rcx+112], 24
	026 JumpIfEqual {48}
	027 Compare [rcx+112], 10
	028 JumpIfEqual {48}
	029 Compare [rcx+112], 42
	030 JumpIfEqual {48}
	031 Compare [rcx+112], 6
	032 JumpIfEqual {48}
	033 Compare [rcx+112], 43
	034 JumpIfEqual {46}
	035 Compare [rcx+112], 19
	036 JumpIfEqual {44}
	037 Compare [rcx+112], 50
	038 Move rax, 17
	039 Move rdx, 1
	040 JumpIfEqual {42}
	041 Move rax, rdx
	042 Nop 
	043 Return rax
	044 Move rax, 5
	045 Return rax
	046 Move rax, 11
	047 Return rax
	048 Move rax, 9
	049 Return rax
	050 Move rax, 77
	051 Return rax
	052 Move rax, 13
	053 Return rax
	054 Move rax, 127
	055 Return rax
	056 Move rax, 0
	057 Compare rdx, 1
	058 NotImplemented "setne al"
	059 Add rax, rax, 1
	060 Return rax
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
