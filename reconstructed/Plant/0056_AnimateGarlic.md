# System.Void AnimateGarlic()

- 类：`Plant`
- 汇编行数：191

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	push rdi
	sub rsp,20h
	cmp byte ptr [184EEB672h],0
	mov rbx,rcx
	jne short 00000001806AB38Dh
	lea rcx,[184C94A90h]
	call 00000001804FEB70h
	lea rcx,[184C5E1C8h]
	call 00000001804FEB70h
	lea rcx,[184C5E0E8h]
	call 00000001804FEB70h
	lea rcx,[184C3FD90h]
	call 00000001804FEB70h
	mov byte ptr [184EEB672h],1
	mov rcx,[rbx+140h]
	mov rdi,[184C94A90h]
	test rcx,rcx
	je near ptr 00000001806AB4B4h
	xor r8d,r8d
	mov rdx,rdi
	call 00000001807C9B90h
	mov r9,rax
	mov eax,55555556h
	imul dword ptr [rbx+90h]
	mov ecx,edx
	shr ecx,1Fh
	add edx,ecx
	cmp [rbx+8Ch],edx
	jl near ptr 00000001806AB455h
	mov ecx,[rbx+90h]
	mov eax,55555556h
	add ecx,ecx
	imul ecx
	mov eax,edx
	shr eax,1Fh
	add edx,eax
	cmp [rbx+8Ch],edx
	jl short 00000001806AB417h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806AB4B4h
	xor r9d,r9d
	xor r8d,r8d
	mov rdx,rdi
	call 00000001807CAE90h
	mov rbx,[rsp+30h]
	add rsp,20h
	pop rdi
	ret
	mov rdx,[184C5E0E8h]
	xor r8d,r8d
	mov rcx,r9
	call 0000000182A27F50h
	test al,al
	je short 00000001806AB40Ch
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806AB4B4h
	mov r8,[184C5E0E8h]
	xor r9d,r9d
	mov rdx,rdi
	mov rbx,[rsp+30h]
	add rsp,20h
	pop rdi
	jmp near ptr 00000001807CAE90h
	mov rdx,[184C5E1C8h]
	xor r8d,r8d
	mov rcx,r9
	call 0000000182A27F50h
	test al,al
	je short 00000001806AB40Ch
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806AB4B4h
	mov r8,[184C5E1C8h]
	xor r9d,r9d
	mov rdx,rdi
	call 00000001807CAE90h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806AB4B4h
	mov rdx,[184C3FD90h]
	xor r9d,r9d
	mov r8d,0FFFFFFFFh
	mov rbx,[rsp+30h]
	add rsp,20h
	pop rdi
	jmp near ptr 00000001807C8DB0h
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rdi
	004 ShiftStack -32
	005 Compare [0x184EEB672], 0
	006 Move rbx, rcx
	007 JumpIfNotEqual {17}
	008 LoadAddress rcx, [0x184C94A90]
	009 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	010 LoadAddress rcx, [0x184C5E1C8]
	011 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	012 LoadAddress rcx, [0x184C5E0E8]
	013 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	014 LoadAddress rcx, [0x184C3FD90]
	015 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	016 Move [0x184EEB672], 1
	017 Move rcx, [rbx+320]
	018 Move rdi, "anim_face"
	019 Compare rcx, 0
	020 JumpIfEqual {96}
	021 Move r8, 0
	022 Move rdx, rdi
	023 Call ReloadedController.GetImageOverride, rcx, rdx
	024 Move r9, rax
	025 Move rax, 0x55555556
	026 NotImplemented "imul dword ptr [rbx+90h]"
	027 Move rcx, rdx
	028 ShiftRight rcx, 31
	029 Add rdx, rdx, rcx
	030 Compare [rbx+140], rdx
	031 JumpIfLess {71}
	032 Move rcx, [rbx+144]
	033 Move rax, 0x55555556
	034 Add rcx, rcx, rcx
	035 NotImplemented "imul ecx"
	036 Move rax, rdx
	037 ShiftRight rax, 31
	038 Add rdx, rdx, rax
	039 Compare [rbx+140], rdx
	040 JumpIfLess {53}
	041 Move rcx, [rbx+320]
	042 Compare rcx, 0
	043 JumpIfEqual {96}
	044 Move r9, 0
	045 Move r8, 0
	046 Move rdx, rdi
	047 Call ReloadedController.SetImageOverride, rcx, rdx, r8
	048 Move rbx, stack:0x30
	049 ShiftStack 32
	050 Move rdi, stack:0x0
	051 ShiftStack 8
	052 Return 
	053 Move rdx, "IMAGE_REANIM_GARLIC_BODY2"
	054 Move r8, 0
	055 Move rcx, r9
	056 Call String.op_Inequality, rcx, rdx, r8
	057 Compare rax, 0
	058 JumpIfEqual {48}
	059 Move rcx, [rbx+320]
	060 Compare rcx, 0
	061 JumpIfEqual {96}
	062 Move r8, "IMAGE_REANIM_GARLIC_BODY2"
	063 Move r9, 0
	064 Move rdx, rdi
	065 Move rbx, stack:0x30
	066 ShiftStack 32
	067 Move rdi, stack:0x0
	068 ShiftStack 8
	069 Call ReloadedController.SetImageOverride, rcx, rdx, r8
	070 Return 
	071 Move rdx, "IMAGE_REANIM_GARLIC_BODY3"
	072 Move r8, 0
	073 Move rcx, r9
	074 Call String.op_Inequality, rcx, rdx, r8
	075 Compare rax, 0
	076 JumpIfEqual {48}
	077 Move rcx, [rbx+320]
	078 Compare rcx, 0
	079 JumpIfEqual {96}
	080 Move r8, "IMAGE_REANIM_GARLIC_BODY3"
	081 Move r9, 0
	082 Move rdx, rdi
	083 Call ReloadedController.SetImageOverride, rcx, rdx, r8
	084 Move rcx, [rbx+320]
	085 Compare rcx, 0
	086 JumpIfEqual {96}
	087 Move rdx, "Garlic_stem"
	088 Move r9, 0
	089 Move r8, 0xFFFFFFFF
	090 Move rbx, stack:0x30
	091 ShiftStack 32
	092 Move rdi, stack:0x0
	093 ShiftStack 8
	094 Call ReloadedController.AssignRenderGroupToPrefix, rcx, rdx, r8
	095 Return 
	096 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
