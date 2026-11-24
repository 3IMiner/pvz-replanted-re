# System.Void UpdateImitater()

- 类：`Plant`
- 汇编行数：208

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,40h
	cmp byte ptr [184EEB675h],0
	mov rbx,rcx
	jne short 00000001806B9985h
	lea rcx,[184C949B8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB675h],1
	cmp dword ptr [rbx+88h],2Ah
	mov [rsp+50h],rdi
	jne near ptr 00000001806B9A93h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B9B2Ch
	movss xmm1,dword ptr [183C33EBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8910h
	xor edi,edi
	test al,al
	je short 00000001806B99FFh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B9B2Ch
	movss xmm2,dword ptr [rbx+24h]
	mov r9d,61A80h
	movss xmm1,dword ptr [rbx+20h]
	addss xmm2,dword ptr [183C33DC4h]
	addss xmm1,dword ptr [183C33DC4h]
	mov [rsp+28h],rdi
	mov dword ptr [rsp+20h],47h
	call 00000001807D9B50h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B9B2Ch
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle short 00000001806B9A88h
	xor edx,edx
	mov rcx,rbx
	call 00000001806ACD40h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B9B2Ch
	mov r9d,[rbx+12Ch]
	mov r8d,[rbx+34h]
	mov edx,[rbx+74h]
	mov [rsp+38h],rdi
	mov [rsp+30h],dil
	mov [rsp+28h],dil
	mov dword ptr [rsp+20h],30h
	call 00000001806553E0h
	mov rbx,rax
	test rax,rax
	je near ptr 00000001806B9B2Ch
	mov rcx,[rax+140h]
	test rcx,rcx
	je near ptr 00000001806B9B2Ch
	xor edx,edx
	call 00000001807B6EF0h
	mov byte ptr [rbx+139h],1
	mov rdi,[rsp+50h]
	add rsp,40h
	pop rbx
	ret
	cmp dword ptr [rbx+0A0h],0
	jne short 00000001806B9A88h
	cmp byte ptr [184EEB658h],0
	mov dword ptr [rbx+88h],2Ah
	mov rdi,[184C949B8h]
	jne short 00000001806B9AD5h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je short 00000001806B9B2Ch
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B9B2Ch
	movss xmm3,dword ptr [183C33FB0h]
	xor edi,edi
	mov [rsp+28h],rdi
	xor r8d,r8d
	mov rdx,rax
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov rdi,[rsp+50h]
	add rsp,40h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -64
	004 Compare [0x184EEB675], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {10}
	007 LoadAddress rcx, [0x184C949B8]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 Move [0x184EEB675], 1
	010 Compare [rbx+136], 42
	011 Move stack:0x50, rdi
	012 JumpIfNotEqual {70}
	013 Move rcx, [rbx+320]
	014 Compare rcx, 0
	015 JumpIfEqual {103}
	016 Move xmm1, [0x183C33EBC]
	017 Move r9, 0
	018 Move r8, 0
	019 Call ReloadedCharacterController.ShouldTriggerTimedEvent, rcx, rdx, r8
	020 Move rdi, 0
	021 Compare rax, 0
	022 JumpIfEqual {34}
	023 Move rcx, [rbx+16]
	024 Compare rcx, 0
	025 JumpIfEqual {103}
	026 Move xmm2, [rbx+36]
	027 Move r9, 0x61A80
	028 Move xmm1, [rbx+32]
	029 Add xmm2, xmm2, [0x183C33DC4]
	030 Add xmm1, xmm1, [0x183C33DC4]
	031 Move stack:0x28, rdi
	032 Move stack:0x20, 71
	033 Call GameplayActivity.AddTodParticle, rcx, xmm1, r8, r9, stack:0x0
	034 Move rcx, [rbx+320]
	035 Compare rcx, 0
	036 JumpIfEqual {103}
	037 Move r8, 0
	038 Move rdx, 0
	039 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	040 Compare rax, 0
	041 JumpIfLessOrEqual {65}
	042 Move rdx, 0
	043 Move rcx, rbx
	044 Call Plant.Die, rcx, rdx
	045 Move rcx, [rbx+24]
	046 Compare rcx, 0
	047 JumpIfEqual {103}
	048 Move r9, [rbx+300]
	049 Move r8, [rbx+52]
	050 Move rdx, [rbx+116]
	051 Move stack:0x38, rdi
	052 Move stack:0x30, rdi
	053 Move stack:0x28, rdi
	054 Move stack:0x20, 48
	055 Call Board.AddPlant, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	056 Move rbx, rax
	057 Compare rax, 0
	058 JumpIfEqual {103}
	059 Move rcx, [rax+320]
	060 Compare rcx, 0
	061 JumpIfEqual {103}
	062 Move rdx, 0
	063 Call PlantController.EnableGrayscale, rcx, rdx
	064 Move [rbx+313], 1
	065 Move rdi, stack:0x50
	066 ShiftStack 64
	067 Move rbx, stack:0x0
	068 ShiftStack 8
	069 Return 
	070 Compare [rbx+160], 0
	071 JumpIfNotEqual {65}
	072 Compare [0x184EEB658], 0
	073 Move [rbx+136], 42
	074 Move rdi, "anim_explode"
	075 JumpIfNotEqual {81}
	076 LoadAddress rcx, [0x184C92A80]
	077 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	078 LoadAddress rcx, [0x184C911F8]
	079 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	080 Move [0x184EEB658], 1
	081 Compare rdi, 0
	082 JumpIfEqual {103}
	083 Move r8, ""
	084 Move r9, 0
	085 Move rdx, "anim_"
	086 Move rcx, rdi
	087 Call String.Replace, rcx, rdx, r8
	088 Move rcx, [rbx+320]
	089 Compare rcx, 0
	090 JumpIfEqual {103}
	091 Move xmm3, [0x183C33FB0]
	092 Move rdi, 0
	093 Move stack:0x28, rdi
	094 Move r8, 0
	095 Move rdx, rax
	096 Move stack:0x20, 3
	097 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	098 Move rdi, stack:0x50
	099 ShiftStack 64
	100 Move rbx, stack:0x0
	101 ShiftStack 8
	102 Return 
	103 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
