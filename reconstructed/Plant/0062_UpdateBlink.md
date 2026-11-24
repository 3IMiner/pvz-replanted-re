# System.Void UpdateBlink()

- 类：`Plant`
- 汇编行数：219

## 反汇编

```asm

Disassembly:
	push rdi
	sub rsp,30h
	cmp byte ptr [184EEB657h],0
	mov rdi,rcx
	jne short 00000001806B7AF1h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	lea rcx,[184C98670h]
	call 00000001804FEB70h
	mov byte ptr [184EEB657h],1
	mov rcx,[rdi+140h]
	mov [rsp+40h],rbx
	test rcx,rcx
	je near ptr 00000001806B7C8Dh
	xor r8d,r8d
	mov edx,1
	call 00000001807C7A30h
	test eax,eax
	jle short 00000001806B7B2Eh
	mov rcx,[rdi+140h]
	test rcx,rcx
	je near ptr 00000001806B7C8Dh
	xor edx,edx
	call 00000001807C7650h
	cmp byte ptr [rdi+136h],0
	jne near ptr 00000001806B7C34h
	cmp dword ptr [rdi+70h],1
	jne near ptr 00000001806B7C67h
	mov rcx,[184C2D478h]
	mov rbx,[rdi+10h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B7B5Eh
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rbx
	call 0000000183832900h
	test al,al
	je near ptr 00000001806B7C3Fh
	mov rax,[rdi+10h]
	test rax,rax
	je near ptr 00000001806B7C8Dh
	mov rcx,[rax+0C8h]
	test rcx,rcx
	je near ptr 00000001806B7C3Fh
	cmp byte ptr [rcx+82h],0
	je near ptr 00000001806B7C3Fh
	mov ebx,[rdi+0F8h]
	xor ecx,ecx
	call 000000018063CD70h
	cmp ebx,eax
	jne near ptr 00000001806B7C34h
	mov rcx,[rdi+140h]
	test rcx,rcx
	je near ptr 00000001806B7C8Dh
	mov rdx,[184C98670h]
	xor r8d,r8d
	call 00000001807C7E60h
	test al,al
	je short 00000001806B7C34h
	mov rcx,[rdi+10h]
	test rcx,rcx
	je near ptr 00000001806B7C8Dh
	movss xmm2,dword ptr [rdi+24h]
	movss xmm1,dword ptr [rdi+20h]
	mov r9d,[rdi+38h]
	addss xmm2,dword ptr [183C33FB8h]
	addss xmm1,dword ptr [183C33EF8h]
	add r9d,2
	mov qword ptr [rsp+28h],0
	mov dword ptr [rsp+20h],44h
	call 00000001807D96D0h
	mov rcx,[rdi+10h]
	test rcx,rcx
	je short 00000001806B7C8Dh
	xor r8d,r8d
	mov rdx,rax
	call 00000001807E13A0h
	mov [rdi+0F8h],eax
	mov rbx,[rsp+40h]
	add rsp,30h
	pop rdi
	ret
	mov ebx,[rdi+0F8h]
	xor ecx,ecx
	call 000000018063CD70h
	cmp ebx,eax
	je short 00000001806B7C67h
	xor edx,edx
	mov rcx,rdi
	call 00000001806B4E30h
	xor ecx,ecx
	call 000000018063CD70h
	mov [rdi+0F8h],eax
	cmp dword ptr [rdi+0FCh],0
	jle short 00000001806B7C34h
	sub dword ptr [rdi+0FCh],1
	jne short 00000001806B7C34h
	xor edx,edx
	mov rcx,rdi
	mov rbx,[rsp+40h]
	add rsp,30h
	pop rdi
	jmp near ptr 00000001806AD260h
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rdi
	003 ShiftStack -48
	004 Compare [0x184EEB657], 0
	005 Move rdi, rcx
	006 JumpIfNotEqual {12}
	007 LoadAddress rcx, [0x184C2D478]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C98670]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 Move [0x184EEB657], 1
	012 Move rcx, [rdi+320]
	013 Move stack:0x40, rbx
	014 Compare rcx, 0
	015 JumpIfEqual {109}
	016 Move r8, 0
	017 Move rdx, 1
	018 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	019 Compare rax, 0
	020 JumpIfLessOrEqual {26}
	021 Move rcx, [rdi+320]
	022 Compare rcx, 0
	023 JumpIfEqual {109}
	024 Move rdx, 0
	025 Call ReloadedCharacterController.DisableBlink, rcx, rdx
	026 Compare [rdi+310], 0
	027 JumpIfNotEqual {81}
	028 Compare [rdi+112], 1
	029 JumpIfNotEqual {97}
	030 Move rcx, typeof(UnityEngine.Object)
	031 Move rbx, [rdi+16]
	032 Compare [rcx+228], 0
	033 JumpIfNotEqual {35}
	034 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	035 Move r8, 0
	036 Move rdx, 0
	037 Move rcx, rbx
	038 Call Object.op_Inequality, rcx, rdx, r8
	039 Compare rax, 0
	040 JumpIfEqual {86}
	041 Move rax, [rdi+16]
	042 Compare rax, 0
	043 JumpIfEqual {109}
	044 Move rcx, [rax+200]
	045 Compare rcx, 0
	046 JumpIfEqual {86}
	047 Compare [rcx+130], 0
	048 JumpIfEqual {86}
	049 Move rbx, [rdi+248]
	050 Move rcx, 0
	051 Call 0x18063CD70, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	052 Compare rbx, rax
	053 JumpIfNotEqual {81}
	054 Move rcx, [rdi+320]
	055 Compare rcx, 0
	056 JumpIfEqual {109}
	057 Move rdx, "anim_sleep"
	058 Move r8, 0
	059 Call ReloadedCharacterController.IsAnimationPlaying, rcx, rdx
	060 Compare rax, 0
	061 JumpIfEqual {81}
	062 Move rcx, [rdi+16]
	063 Compare rcx, 0
	064 JumpIfEqual {109}
	065 Move xmm2, [rdi+36]
	066 Move xmm1, [rdi+32]
	067 Move r9, [rdi+56]
	068 Add xmm2, xmm2, [0x183C33FB8]
	069 Add xmm1, xmm1, [0x183C33EF8]
	070 Add r9, r9, 2
	071 Move stack:0x28, 0
	072 Move stack:0x20, 68
	073 Call GameplayActivity.AddReanimation, rcx, xmm1, r8, r9, stack:0x0
	074 Move rcx, [rdi+16]
	075 Compare rcx, 0
	076 JumpIfEqual {109}
	077 Move r8, 0
	078 Move rdx, rax
	079 Call GameplayActivity.ReanimationGetID, rcx, rdx
	080 Move [rdi+248], rax
	081 Move rbx, stack:0x40
	082 ShiftStack 48
	083 Move rdi, stack:0x0
	084 ShiftStack 8
	085 Return 
	086 Move rbx, [rdi+248]
	087 Move rcx, 0
	088 Call 0x18063CD70, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	089 Compare rbx, rax
	090 JumpIfEqual {97}
	091 Move rdx, 0
	092 Move rcx, rdi
	093 Call Plant.RemoveEffects, rcx, rdx
	094 Move rcx, 0
	095 Call 0x18063CD70, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	096 Move [rdi+248], rax
	097 Compare [rdi+252], 0
	098 JumpIfLessOrEqual {81}
	099 Subtract [rdi+252], [rdi+252], 1
	100 JumpIfNotEqual {81}
	101 Move rdx, 0
	102 Move rcx, rdi
	103 Move rbx, stack:0x40
	104 ShiftStack 48
	105 Move rdi, stack:0x0
	106 ShiftStack 8
	107 Call Plant.DoBlink, rcx, rdx
	108 Return 
	109 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
