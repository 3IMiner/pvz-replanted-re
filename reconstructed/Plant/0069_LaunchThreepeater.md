# System.Void LaunchThreepeater()

- 类：`Plant`
- 汇编行数：261

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	mov [rsp+10h],rsi
	push rdi
	sub rsp,30h
	cmp byte ptr [184EEB641h],0
	mov rbx,rcx
	jne short 00000001806B2736h
	lea rcx,[184C7DC88h]
	call 00000001804FEB70h
	lea rcx,[184C7DD60h]
	call 00000001804FEB70h
	lea rcx,[184C7DE38h]
	call 00000001804FEB70h
	mov byte ptr [184EEB641h],1
	mov esi,[rbx+34h]
	xor r9d,r9d
	mov edi,[rbx+34h]
	xor r8d,r8d
	mov edx,[rbx+34h]
	mov rcx,rbx
	dec esi
	inc edi
	call 00000001806B0040h
	test rax,rax
	jne short 00000001806B27BEh
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B291Bh
	xor r8d,r8d
	mov edx,esi
	call 000000018066E210h
	test al,al
	je short 00000001806B2786h
	xor r9d,r9d
	xor r8d,r8d
	mov edx,esi
	mov rcx,rbx
	call 00000001806B0040h
	test rax,rax
	jne short 00000001806B27BEh
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B291Bh
	xor r8d,r8d
	mov edx,edi
	call 000000018066E210h
	test al,al
	je near ptr 00000001806B290Bh
	xor r9d,r9d
	xor r8d,r8d
	mov edx,edi
	mov rcx,rbx
	call 00000001806B0040h
	test rax,rax
	je near ptr 00000001806B290Bh
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B291Bh
	xor r8d,r8d
	mov edx,edi
	call 000000018066E210h
	xor edi,edi
	test al,al
	je short 00000001806B2838h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B291Bh
	movss xmm1,dword ptr [183C33DACh]
	xor r9d,r9d
	mov r8d,2
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B291Bh
	movss xmm3,dword ptr [183C33DBCh]
	mov r8d,2
	mov rdx,[184C7DC88h]
	mov [rsp+28h],rdi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B291Bh
	movss xmm1,dword ptr [183C33DACh]
	xor r9d,r9d
	mov r8d,3
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B291Bh
	movss xmm3,dword ptr [183C33DBCh]
	mov r8d,3
	mov rdx,[184C7DD60h]
	mov [rsp+28h],rdi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je short 00000001806B291Bh
	xor r8d,r8d
	mov edx,esi
	call 000000018066E210h
	test al,al
	je short 00000001806B2901h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B291Bh
	movss xmm1,dword ptr [183C33DACh]
	xor r9d,r9d
	mov r8d,4
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B291Bh
	movss xmm3,dword ptr [183C33DBCh]
	mov r8d,4
	mov rdx,[184C7DE38h]
	mov [rsp+28h],rdi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov dword ptr [rbx+0DCh],23h
	mov rbx,[rsp+40h]
	mov rsi,[rsp+48h]
	add rsp,30h
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 Move stack:0x10, rsi
	003 ShiftStack -8
	004 Move stack:0x0, rdi
	005 ShiftStack -48
	006 Compare [0x184EEB641], 0
	007 Move rbx, rcx
	008 JumpIfNotEqual {16}
	009 LoadAddress rcx, [0x184C7DC88]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184C7DD60]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 LoadAddress rcx, [0x184C7DE38]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 Move [0x184EEB641], 1
	016 Move rsi, [rbx+52]
	017 Move r9, 0
	018 Move rdi, [rbx+52]
	019 Move r8, 0
	020 Move rdx, [rbx+52]
	021 Move rcx, rbx
	022 Subtract rsi, rsi, 1
	023 Add rdi, rdi, 1
	024 Call Plant.FindTargetZombie, rcx, rdx, r8
	025 Compare rax, 0
	026 JumpIfNotEqual {57}
	027 Move rcx, [rbx+24]
	028 Compare rcx, 0
	029 JumpIfEqual {129}
	030 Move r8, 0
	031 Move rdx, rsi
	032 Call Board.RowCanHaveZombies, rcx, rdx
	033 Compare rax, 0
	034 JumpIfEqual {42}
	035 Move r9, 0
	036 Move r8, 0
	037 Move rdx, rsi
	038 Move rcx, rbx
	039 Call Plant.FindTargetZombie, rcx, rdx, r8
	040 Compare rax, 0
	041 JumpIfNotEqual {57}
	042 Move rcx, [rbx+24]
	043 Compare rcx, 0
	044 JumpIfEqual {129}
	045 Move r8, 0
	046 Move rdx, rdi
	047 Call Board.RowCanHaveZombies, rcx, rdx
	048 Compare rax, 0
	049 JumpIfEqual {123}
	050 Move r9, 0
	051 Move r8, 0
	052 Move rdx, rdi
	053 Move rcx, rbx
	054 Call Plant.FindTargetZombie, rcx, rdx, r8
	055 Compare rax, 0
	056 JumpIfEqual {123}
	057 Move rcx, [rbx+24]
	058 Compare rcx, 0
	059 JumpIfEqual {129}
	060 Move r8, 0
	061 Move rdx, rdi
	062 Call Board.RowCanHaveZombies, rcx, rdx
	063 Move rdi, 0
	064 Compare rax, 0
	065 JumpIfEqual {82}
	066 Move rcx, [rbx+320]
	067 Compare rcx, 0
	068 JumpIfEqual {129}
	069 Move xmm1, [0x183C33DAC]
	070 Move r9, 0
	071 Move r8, 2
	072 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	073 Move rcx, [rbx+320]
	074 Compare rcx, 0
	075 JumpIfEqual {129}
	076 Move xmm3, [0x183C33DBC]
	077 Move r8, 2
	078 Move rdx, "shooting1"
	079 Move stack:0x28, rdi
	080 Move stack:0x20, 3
	081 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	082 Move rcx, [rbx+320]
	083 Compare rcx, 0
	084 JumpIfEqual {129}
	085 Move xmm1, [0x183C33DAC]
	086 Move r9, 0
	087 Move r8, 3
	088 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	089 Move rcx, [rbx+320]
	090 Compare rcx, 0
	091 JumpIfEqual {129}
	092 Move xmm3, [0x183C33DBC]
	093 Move r8, 3
	094 Move rdx, "shooting2"
	095 Move stack:0x28, rdi
	096 Move stack:0x20, 3
	097 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	098 Move rcx, [rbx+24]
	099 Compare rcx, 0
	100 JumpIfEqual {129}
	101 Move r8, 0
	102 Move rdx, rsi
	103 Call Board.RowCanHaveZombies, rcx, rdx
	104 Compare rax, 0
	105 JumpIfEqual {122}
	106 Move rcx, [rbx+320]
	107 Compare rcx, 0
	108 JumpIfEqual {129}
	109 Move xmm1, [0x183C33DAC]
	110 Move r9, 0
	111 Move r8, 4
	112 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	113 Move rcx, [rbx+320]
	114 Compare rcx, 0
	115 JumpIfEqual {129}
	116 Move xmm3, [0x183C33DBC]
	117 Move r8, 4
	118 Move rdx, "shooting3"
	119 Move stack:0x28, rdi
	120 Move stack:0x20, 3
	121 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	122 Move [rbx+220], 35
	123 Move rbx, stack:0x40
	124 Move rsi, stack:0x48
	125 ShiftStack 48
	126 Move rdi, stack:0x0
	127 ShiftStack 8
	128 Return 
	129 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
