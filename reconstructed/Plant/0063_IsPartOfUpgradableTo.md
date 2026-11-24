# System.Boolean IsPartOfUpgradableTo(Reloaded.Gameplay.SeedType aUpdatedType)

- 类：`Plant`
- 汇编行数：219

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,30h
	mov rbx,rcx
	cmp edx,2Fh
	jne short 00000001806B2351h
	cmp dword ptr [rcx+70h],22h
	jne near ptr 00000001806B2415h
	mov rcx,[rcx+18h]
	test rcx,rcx
	je near ptr 00000001806B241Dh
	mov r8d,[rbx+34h]
	xor r9d,r9d
	mov edx,[rbx+74h]
	call 0000000180662310h
	test al,al
	jne short 00000001806B2377h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B241Dh
	mov edx,[rbx+74h]
	xor r9d,r9d
	mov r8d,[rbx+34h]
	dec edx
	call 0000000180662310h
	test al,al
	setne al
	add rsp,30h
	pop rbx
	ret
	cmp edx,28h
	jne short 00000001806B2368h
	cmp dword ptr [rcx+70h],7
	jne near ptr 00000001806B2415h
	mov al,1
	add rsp,30h
	pop rbx
	ret
	cmp edx,2Ch
	jne short 00000001806B237Fh
	cmp dword ptr [rcx+70h],27h
	jne near ptr 00000001806B2415h
	mov al,1
	add rsp,30h
	pop rbx
	ret
	cmp edx,29h
	jne short 00000001806B2396h
	cmp dword ptr [rcx+70h],1
	jne near ptr 00000001806B2415h
	mov al,1
	add rsp,30h
	pop rbx
	ret
	cmp edx,2Eh
	jne short 00000001806B23A9h
	cmp dword ptr [rcx+70h],15h
	jne short 00000001806B2415h
	mov al,1
	add rsp,30h
	pop rbx
	ret
	cmp edx,2Dh
	jne short 00000001806B23BCh
	cmp dword ptr [rcx+70h],1Fh
	jne short 00000001806B2415h
	mov al,1
	add rsp,30h
	pop rbx
	ret
	cmp edx,2Ah
	jne short 00000001806B23CFh
	cmp dword ptr [rcx+70h],0Ah
	jne short 00000001806B2415h
	mov al,1
	add rsp,30h
	pop rbx
	ret
	cmp edx,2Bh
	jne short 00000001806B2415h
	cmp dword ptr [rcx+70h],10h
	jne short 00000001806B2415h
	mov rcx,[rcx+18h]
	test rcx,rcx
	je short 00000001806B241Dh
	mov r8d,[rbx+34h]
	mov r9d,6
	mov edx,[rbx+74h]
	mov qword ptr [rsp+20h],0
	call 000000018065F2A0h
	test rax,rax
	je near ptr 00000001806B2377h
	cmp dword ptr [rax+70h],2Bh
	je short 00000001806B2415h
	mov al,1
	add rsp,30h
	pop rbx
	ret
	xor al,al
	add rsp,30h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -48
	004 Move rbx, rcx
	005 Compare rdx, 47
	006 JumpIfNotEqual {32}
	007 Compare [rcx+112], 34
	008 JumpIfNotEqual {107}
	009 Move rcx, [rcx+24]
	010 Compare rcx, 0
	011 JumpIfEqual {112}
	012 Move r8, [rbx+52]
	013 Move r9, 0
	014 Move rdx, [rbx+116]
	015 Call Board.IsValidCobCannonSpot, rcx, rdx, r8
	016 Compare rax, 0
	017 JumpIfNotEqual {45}
	018 Move rcx, [rbx+24]
	019 Compare rcx, 0
	020 JumpIfEqual {112}
	021 Move rdx, [rbx+116]
	022 Move r9, 0
	023 Move r8, [rbx+52]
	024 Subtract rdx, rdx, 1
	025 Call Board.IsValidCobCannonSpot, rcx, rdx, r8
	026 Compare rax, 0
	027 NotImplemented "setne al"
	028 ShiftStack 48
	029 Move rbx, stack:0x0
	030 ShiftStack 8
	031 Return rax
	032 Compare rdx, 40
	033 JumpIfNotEqual {41}
	034 Compare [rcx+112], 7
	035 JumpIfNotEqual {107}
	036 Move rax, 1
	037 ShiftStack 48
	038 Move rbx, stack:0x0
	039 ShiftStack 8
	040 Return rax
	041 Compare rdx, 44
	042 JumpIfNotEqual {50}
	043 Compare [rcx+112], 39
	044 JumpIfNotEqual {107}
	045 Move rax, 1
	046 ShiftStack 48
	047 Move rbx, stack:0x0
	048 ShiftStack 8
	049 Return rax
	050 Compare rdx, 41
	051 JumpIfNotEqual {59}
	052 Compare [rcx+112], 1
	053 JumpIfNotEqual {107}
	054 Move rax, 1
	055 ShiftStack 48
	056 Move rbx, stack:0x0
	057 ShiftStack 8
	058 Return rax
	059 Compare rdx, 46
	060 JumpIfNotEqual {68}
	061 Compare [rcx+112], 21
	062 JumpIfNotEqual {107}
	063 Move rax, 1
	064 ShiftStack 48
	065 Move rbx, stack:0x0
	066 ShiftStack 8
	067 Return rax
	068 Compare rdx, 45
	069 JumpIfNotEqual {77}
	070 Compare [rcx+112], 31
	071 JumpIfNotEqual {107}
	072 Move rax, 1
	073 ShiftStack 48
	074 Move rbx, stack:0x0
	075 ShiftStack 8
	076 Return rax
	077 Compare rdx, 42
	078 JumpIfNotEqual {86}
	079 Compare [rcx+112], 10
	080 JumpIfNotEqual {107}
	081 Move rax, 1
	082 ShiftStack 48
	083 Move rbx, stack:0x0
	084 ShiftStack 8
	085 Return rax
	086 Compare rdx, 43
	087 JumpIfNotEqual {107}
	088 Compare [rcx+112], 16
	089 JumpIfNotEqual {107}
	090 Move rcx, [rcx+24]
	091 Compare rcx, 0
	092 JumpIfEqual {112}
	093 Move r8, [rbx+52]
	094 Move r9, 6
	095 Move rdx, [rbx+116]
	096 Move stack:0x20, 0
	097 Call Board.GetTopPlantAt, rcx, rdx, r8, r9
	098 Compare rax, 0
	099 JumpIfEqual {45}
	100 Compare [rax+112], 43
	101 JumpIfEqual {107}
	102 Move rax, 1
	103 ShiftStack 48
	104 Move rbx, stack:0x0
	105 ShiftStack 8
	106 Return rax
	107 Move rax, 0
	108 ShiftStack 48
	109 Move rbx, stack:0x0
	110 ShiftStack 8
	111 Return rax
	112 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
