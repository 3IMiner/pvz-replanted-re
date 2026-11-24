# System.Void UpdateGraveBuster()

- 类：`Plant`
- 汇编行数：278

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,30h
	cmp byte ptr [184EEB64Eh],0
	mov rbx,rcx
	jne short 00000001806B96E5h
	lea rcx,[184C95FA8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB64Eh],1
	cmp dword ptr [rbx+88h],8
	mov [rsp+40h],rsi
	mov [rsp+48h],rdi
	je near ptr 00000001806B980Eh
	cmp dword ptr [rbx+88h],9
	jne near ptr 00000001806B97FEh
	cmp dword ptr [rbx+0A0h],0
	jne near ptr 00000001806B97FEh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B9928h
	xor edx,edx
	call 00000001807DF9F0h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B9928h
	mov r8d,[rbx+34h]
	xor r9d,r9d
	mov edx,[rbx+74h]
	test al,al
	jne short 00000001806B976Eh
	call 000000018065DEF0h
	test rax,rax
	je short 00000001806B9782h
	xor edx,edx
	mov rcx,rax
	call 00000001806C2390h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B9928h
	inc dword ptr [rcx+2F4h]
	jmp short 00000001806B9782h
	call 000000018065F400h
	test rax,rax
	je short 00000001806B9782h
	xor edx,edx
	mov rcx,rax
	call 00000001806EBF90h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B9928h
	movss xmm2,dword ptr [rbx+24h]
	xor edi,edi
	movss xmm1,dword ptr [rbx+20h]
	mov r9d,[rbx+38h]
	addss xmm2,dword ptr [183C33DCCh]
	addss xmm1,dword ptr [183C33DC4h]
	add r9d,4
	mov [rsp+28h],rdi
	mov dword ptr [rsp+20h],19h
	call 00000001807D9B50h
	xor edx,edx
	mov rcx,rbx
	call 00000001806ACD40h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B9928h
	movss xmm1,dword ptr [rbx+20h]
	mov r9d,0Ch
	addss xmm1,dword ptr [183C33DC4h]
	movss xmm2,dword ptr [rbx+24h]
	mov [rsp+20h],rdi
	call 000000018065C570h
	mov rdi,[rsp+48h]
	mov rsi,[rsp+40h]
	add rsp,30h
	pop rbx
	ret
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B9928h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle short 00000001806B97FEh
	cmp byte ptr [184EEB658h],0
	mov rdi,[184C95FA8h]
	jne short 00000001806B985Bh
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806B9928h
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rsi,rax
	test rcx,rcx
	je near ptr 00000001806B9928h
	movss xmm1,dword ptr [183C33DACh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B9928h
	movss xmm3,dword ptr [183C33DB4h]
	xor edi,edi
	mov [rsp+28h],rdi
	xor r8d,r8d
	mov rdx,rsi
	mov [rsp+20h],edi
	call 00000001807C8270h
	movss xmm2,dword ptr [rbx+24h]
	mov rcx,rbx
	movss xmm1,dword ptr [rbx+20h]
	mov r9d,[rbx+38h]
	addss xmm2,dword ptr [183C33DC4h]
	addss xmm1,dword ptr [183C33DC4h]
	add r9d,4
	mov [rsp+28h],rdi
	mov dword ptr [rbx+0A0h],190h
	mov dword ptr [rbx+88h],9
	mov dword ptr [rsp+20h],18h
	call 00000001806AB220h
	mov rdi,[rsp+48h]
	mov rsi,[rsp+40h]
	add rsp,30h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -48
	004 Compare [0x184EEB64E], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {10}
	007 LoadAddress rcx, [0x184C95FA8]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 Move [0x184EEB64E], 1
	010 Compare [rbx+136], 8
	011 Move stack:0x40, rsi
	012 Move stack:0x48, rdi
	013 JumpIfEqual {79}
	014 Compare [rbx+136], 9
	015 JumpIfNotEqual {73}
	016 Compare [rbx+160], 0
	017 JumpIfNotEqual {73}
	018 Move rcx, [rbx+16]
	019 Compare rcx, 0
	020 JumpIfEqual {138}
	021 Move rdx, 0
	022 Call GameplayActivity.IsVersusMode, rcx, rdx
	023 Move rcx, [rbx+24]
	024 Compare rcx, 0
	025 JumpIfEqual {138}
	026 Move r8, [rbx+52]
	027 Move r9, 0
	028 Move rdx, [rbx+116]
	029 Compare rax, 0
	030 JumpIfNotEqual {42}
	031 Call Board.GetGraveStoneAt, rcx, rdx, r8
	032 Compare rax, 0
	033 JumpIfEqual {48}
	034 Move rdx, 0
	035 Move rcx, rax
	036 Call GridItem.GridItemDie, rcx, rdx
	037 Move rcx, [rbx+24]
	038 Compare rcx, 0
	039 JumpIfEqual {138}
	040 Add [rcx+756], [rcx+756], 1
	041 Goto {48}
	042 Call Board.GetVSGravestoneAt, rcx, rdx, r8
	043 Compare rax, 0
	044 JumpIfEqual {48}
	045 Move rdx, 0
	046 Move rcx, rax
	047 Call Zombie.DieNoLoot, rcx, rdx
	048 Move rcx, [rbx+16]
	049 Compare rcx, 0
	050 JumpIfEqual {138}
	051 Move xmm2, [rbx+36]
	052 Move rdi, 0
	053 Move xmm1, [rbx+32]
	054 Move r9, [rbx+56]
	055 Add xmm2, xmm2, [0x183C33DCC]
	056 Add xmm1, xmm1, [0x183C33DC4]
	057 Add r9, r9, 4
	058 Move stack:0x28, rdi
	059 Move stack:0x20, 25
	060 Call GameplayActivity.AddTodParticle, rcx, xmm1, r8, r9, stack:0x0
	061 Move rdx, 0
	062 Move rcx, rbx
	063 Call Plant.Die, rcx, rdx
	064 Move rcx, [rbx+24]
	065 Compare rcx, 0
	066 JumpIfEqual {138}
	067 Move xmm1, [rbx+32]
	068 Move r9, 12
	069 Add xmm1, xmm1, [0x183C33DC4]
	070 Move xmm2, [rbx+36]
	071 Move stack:0x20, rdi
	072 Call Board.DropLootPiece, rcx, xmm1, r8, r9
	073 Move rdi, stack:0x48
	074 Move rsi, stack:0x40
	075 ShiftStack 48
	076 Move rbx, stack:0x0
	077 ShiftStack 8
	078 Return 
	079 Move rcx, [rbx+320]
	080 Compare rcx, 0
	081 JumpIfEqual {138}
	082 Move r8, 0
	083 Move rdx, 0
	084 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	085 Compare rax, 0
	086 JumpIfLessOrEqual {73}
	087 Compare [0x184EEB658], 0
	088 Move rdi, "anim_idle"
	089 JumpIfNotEqual {95}
	090 LoadAddress rcx, [0x184C92A80]
	091 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	092 LoadAddress rcx, [0x184C911F8]
	093 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	094 Move [0x184EEB658], 1
	095 Compare rdi, 0
	096 JumpIfEqual {138}
	097 Move r8, ""
	098 Move r9, 0
	099 Move rdx, "anim_"
	100 Move rcx, rdi
	101 Call String.Replace, rcx, rdx, r8
	102 Move rcx, [rbx+320]
	103 Move rsi, rax
	104 Compare rcx, 0
	105 JumpIfEqual {138}
	106 Move xmm1, [0x183C33DAC]
	107 Move r9, 0
	108 Move r8, 0
	109 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	110 Move rcx, [rbx+320]
	111 Compare rcx, 0
	112 JumpIfEqual {138}
	113 Move xmm3, [0x183C33DB4]
	114 Move rdi, 0
	115 Move stack:0x28, rdi
	116 Move r8, 0
	117 Move rdx, rsi
	118 Move stack:0x20, rdi
	119 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	120 Move xmm2, [rbx+36]
	121 Move rcx, rbx
	122 Move xmm1, [rbx+32]
	123 Move r9, [rbx+56]
	124 Add xmm2, xmm2, [0x183C33DC4]
	125 Add xmm1, xmm1, [0x183C33DC4]
	126 Add r9, r9, 4
	127 Move stack:0x28, rdi
	128 Move [rbx+160], 400
	129 Move [rbx+136], 9
	130 Move stack:0x20, 24
	131 Call Plant.AddAttachedParticle, rcx, xmm1, r8, r9, stack:0x0
	132 Move rdi, stack:0x48
	133 Move rsi, stack:0x40
	134 ShiftStack 48
	135 Move rbx, stack:0x0
	136 ShiftStack 8
	137 Return 
	138 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
