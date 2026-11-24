# System.Boolean IsUpgradableTo(Reloaded.Gameplay.SeedType aUpdatedType)

- 类：`Plant`
- 汇编行数：135

## 反汇编

```asm

Disassembly:
	sub rsp,38h
	cmp edx,28h
	jne short 00000001806B246Ah
	cmp dword ptr [rcx+70h],7
	je near ptr 00000001806B2511h
	xor al,al
	add rsp,38h
	ret
	cmp edx,2Ch
	jne short 00000001806B2475h
	cmp dword ptr [rcx+70h],27h
	jmp short 00000001806B245Dh
	cmp edx,29h
	jne short 00000001806B2480h
	cmp dword ptr [rcx+70h],1
	jmp short 00000001806B245Dh
	cmp edx,2Eh
	jne short 00000001806B248Bh
	cmp dword ptr [rcx+70h],15h
	jmp short 00000001806B245Dh
	cmp edx,2Fh
	jne short 00000001806B24BAh
	cmp dword ptr [rcx+70h],22h
	jne short 00000001806B2463h
	mov rax,[rcx+18h]
	test rax,rax
	je short 00000001806B2518h
	mov r8d,[rcx+34h]
	xor r9d,r9d
	mov edx,[rcx+74h]
	mov rcx,rax
	call 0000000180662310h
	test al,al
	jne short 00000001806B2511h
	add rsp,38h
	ret
	cmp edx,2Dh
	jne short 00000001806B24C5h
	cmp dword ptr [rcx+70h],1Fh
	jmp short 00000001806B245Dh
	cmp edx,2Ah
	jne short 00000001806B24D0h
	cmp dword ptr [rcx+70h],0Ah
	jmp short 00000001806B245Dh
	cmp edx,2Bh
	jne short 00000001806B2463h
	cmp dword ptr [rcx+70h],10h
	jne short 00000001806B2463h
	mov rax,[rcx+18h]
	test rax,rax
	je short 00000001806B2518h
	mov r8d,[rcx+34h]
	mov r9d,6
	mov edx,[rcx+74h]
	mov rcx,rax
	mov qword ptr [rsp+20h],0
	call 000000018065F2A0h
	test rax,rax
	je short 00000001806B2511h
	cmp dword ptr [rax+70h],2Bh
	je near ptr 00000001806B2463h
	mov al,1
	add rsp,38h
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -56
	002 Compare rdx, 40
	003 JumpIfNotEqual {9}
	004 Compare [rcx+112], 7
	005 JumpIfEqual {62}
	006 Move rax, 0
	007 ShiftStack 56
	008 Return rax
	009 Compare rdx, 44
	010 JumpIfNotEqual {13}
	011 Compare [rcx+112], 39
	012 Goto {5}
	013 Compare rdx, 41
	014 JumpIfNotEqual {17}
	015 Compare [rcx+112], 1
	016 Goto {5}
	017 Compare rdx, 46
	018 JumpIfNotEqual {21}
	019 Compare [rcx+112], 21
	020 Goto {5}
	021 Compare rdx, 47
	022 JumpIfNotEqual {37}
	023 Compare [rcx+112], 34
	024 JumpIfNotEqual {6}
	025 Move rax, [rcx+24]
	026 Compare rax, 0
	027 JumpIfEqual {65}
	028 Move r8, [rcx+52]
	029 Move r9, 0
	030 Move rdx, [rcx+116]
	031 Move rcx, rax
	032 Call Board.IsValidCobCannonSpot, rcx, rdx, r8
	033 Compare rax, 0
	034 JumpIfNotEqual {62}
	035 ShiftStack 56
	036 Return rax
	037 Compare rdx, 45
	038 JumpIfNotEqual {41}
	039 Compare [rcx+112], 31
	040 Goto {5}
	041 Compare rdx, 42
	042 JumpIfNotEqual {45}
	043 Compare [rcx+112], 10
	044 Goto {5}
	045 Compare rdx, 43
	046 JumpIfNotEqual {6}
	047 Compare [rcx+112], 16
	048 JumpIfNotEqual {6}
	049 Move rax, [rcx+24]
	050 Compare rax, 0
	051 JumpIfEqual {65}
	052 Move r8, [rcx+52]
	053 Move r9, 6
	054 Move rdx, [rcx+116]
	055 Move rcx, rax
	056 Move stack:0x20, 0
	057 Call Board.GetTopPlantAt, rcx, rdx, r8, r9
	058 Compare rax, 0
	059 JumpIfEqual {62}
	060 Compare [rax+112], 43
	061 JumpIfEqual {6}
	062 Move rax, 1
	063 ShiftStack 56
	064 Return rax
	065 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
