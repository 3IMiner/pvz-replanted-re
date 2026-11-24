# System.Void AnimatePumpkin()

- 类：`Plant`
- 汇编行数：240

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	push rdi
	sub rsp,20h
	cmp byte ptr [184EEB668h],0
	mov rbx,rcx
	jne short 00000001806AB84Dh
	lea rcx,[184C7F588h]
	call 00000001804FEB70h
	lea rcx,[184C5E610h]
	call 00000001804FEB70h
	lea rcx,[184C5E458h]
	call 00000001804FEB70h
	lea rcx,[184C5E538h]
	call 00000001804FEB70h
	mov byte ptr [184EEB668h],1
	mov rcx,[rbx+140h]
	mov rdi,[184C7F588h]
	test rcx,rcx
	je near ptr 00000001806AB9A6h
	xor r8d,r8d
	mov rdx,rdi
	call 00000001807C9B90h
	mov rcx,rax
	mov eax,[rbx+90h]
	cdq
	and edx,3
	add eax,edx
	sar eax,2
	cmp [rbx+8Ch],eax
	jl near ptr 00000001806AB967h
	mov eax,[rbx+90h]
	add eax,eax
	cdq
	and edx,3
	add eax,edx
	sar eax,2
	cmp [rbx+8Ch],eax
	jl near ptr 00000001806AB92Ch
	mov eax,[rbx+90h]
	lea eax,[rax+rax*2]
	cdq
	and edx,3
	add eax,edx
	sar eax,2
	cmp [rbx+8Ch],eax
	jl short 00000001806AB8EDh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806AB9A6h
	xor r9d,r9d
	xor r8d,r8d
	mov rdx,rdi
	call 00000001807CAE90h
	mov rbx,[rsp+30h]
	add rsp,20h
	pop rdi
	ret
	mov rdx,[184C5E458h]
	xor r8d,r8d
	call 0000000182A27F50h
	test al,al
	je short 00000001806AB8E2h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806AB9A6h
	mov r8,[184C5E458h]
	xor r9d,r9d
	mov rdx,rdi
	mov rbx,[rsp+30h]
	add rsp,20h
	pop rdi
	jmp near ptr 00000001807CAE90h
	mov rdx,[184C5E538h]
	xor r8d,r8d
	call 0000000182A27F50h
	test al,al
	je short 00000001806AB8E2h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806AB9A6h
	mov r8,[184C5E538h]
	xor r9d,r9d
	mov rdx,rdi
	mov rbx,[rsp+30h]
	add rsp,20h
	pop rdi
	jmp near ptr 00000001807CAE90h
	mov rdx,[184C5E610h]
	xor r8d,r8d
	call 0000000182A27F50h
	test al,al
	je near ptr 00000001806AB8E2h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806AB9A6h
	mov r8,[184C5E610h]
	xor r9d,r9d
	mov rdx,rdi
	mov rbx,[rsp+30h]
	add rsp,20h
	pop rdi
	jmp near ptr 00000001807CAE90h
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rdi
	004 ShiftStack -32
	005 Compare [0x184EEB668], 0
	006 Move rbx, rcx
	007 JumpIfNotEqual {17}
	008 LoadAddress rcx, [0x184C7F588]
	009 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	010 LoadAddress rcx, [0x184C5E610]
	011 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	012 LoadAddress rcx, [0x184C5E458]
	013 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	014 LoadAddress rcx, [0x184C5E538]
	015 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	016 Move [0x184EEB668], 1
	017 Move rcx, [rbx+320]
	018 Move rdi, "Pumpkin_front"
	019 Compare rcx, 0
	020 JumpIfEqual {132}
	021 Move r8, 0
	022 Move rdx, rdi
	023 Call ReloadedController.GetImageOverride, rcx, rdx
	024 Move rcx, rax
	025 Move rax, [rbx+144]
	026 Move TEMP, rax
	027 ShiftRight TEMP, 31
	028 Compare TEMP, 1
	029 JumpIfNotEqual {32}
	030 Move rdx, 0xFFFFFFFF
	031 Goto {33}
	032 Move rdx, 0
	033 Nop 
	034 And rdx, rdx, 3
	035 Add rax, rax, rdx
	036 ShiftRight rax, 2
	037 Compare [rbx+140], rax
	038 JumpIfLess {115}
	039 Move rax, [rbx+144]
	040 Add rax, rax, rax
	041 Move TEMP, rax
	042 ShiftRight TEMP, 31
	043 Compare TEMP, 1
	044 JumpIfNotEqual {47}
	045 Move rdx, 0xFFFFFFFF
	046 Goto {48}
	047 Move rdx, 0
	048 Nop 
	049 And rdx, rdx, 3
	050 Add rax, rax, rdx
	051 ShiftRight rax, 2
	052 Compare [rbx+140], rax
	053 JumpIfLess {98}
	054 Move rax, [rbx+144]
	055 LoadAddress rax, [rax+rax*2]
	056 Move TEMP, rax
	057 ShiftRight TEMP, 31
	058 Compare TEMP, 1
	059 JumpIfNotEqual {62}
	060 Move rdx, 0xFFFFFFFF
	061 Goto {63}
	062 Move rdx, 0
	063 Nop 
	064 And rdx, rdx, 3
	065 Add rax, rax, rdx
	066 ShiftRight rax, 2
	067 Compare [rbx+140], rax
	068 JumpIfLess {81}
	069 Move rcx, [rbx+320]
	070 Compare rcx, 0
	071 JumpIfEqual {132}
	072 Move r9, 0
	073 Move r8, 0
	074 Move rdx, rdi
	075 Call ReloadedController.SetImageOverride, rcx, rdx, r8
	076 Move rbx, stack:0x30
	077 ShiftStack 32
	078 Move rdi, stack:0x0
	079 ShiftStack 8
	080 Return 
	081 Move rdx, "IMAGE_REANIM_PUMPKIN_DAMAGE1"
	082 Move r8, 0
	083 Call String.op_Inequality, rcx, rdx, r8
	084 Compare rax, 0
	085 JumpIfEqual {76}
	086 Move rcx, [rbx+320]
	087 Compare rcx, 0
	088 JumpIfEqual {132}
	089 Move r8, "IMAGE_REANIM_PUMPKIN_DAMAGE1"
	090 Move r9, 0
	091 Move rdx, rdi
	092 Move rbx, stack:0x30
	093 ShiftStack 32
	094 Move rdi, stack:0x0
	095 ShiftStack 8
	096 Call ReloadedController.SetImageOverride, rcx, rdx, r8
	097 Return 
	098 Move rdx, "IMAGE_REANIM_PUMPKIN_DAMAGE2"
	099 Move r8, 0
	100 Call String.op_Inequality, rcx, rdx, r8
	101 Compare rax, 0
	102 JumpIfEqual {76}
	103 Move rcx, [rbx+320]
	104 Compare rcx, 0
	105 JumpIfEqual {132}
	106 Move r8, "IMAGE_REANIM_PUMPKIN_DAMAGE2"
	107 Move r9, 0
	108 Move rdx, rdi
	109 Move rbx, stack:0x30
	110 ShiftStack 32
	111 Move rdi, stack:0x0
	112 ShiftStack 8
	113 Call ReloadedController.SetImageOverride, rcx, rdx, r8
	114 Return 
	115 Move rdx, "IMAGE_REANIM_PUMPKIN_DAMAGE3"
	116 Move r8, 0
	117 Call String.op_Inequality, rcx, rdx, r8
	118 Compare rax, 0
	119 JumpIfEqual {76}
	120 Move rcx, [rbx+320]
	121 Compare rcx, 0
	122 JumpIfEqual {132}
	123 Move r8, "IMAGE_REANIM_PUMPKIN_DAMAGE3"
	124 Move r9, 0
	125 Move rdx, rdi
	126 Move rbx, stack:0x30
	127 ShiftStack 32
	128 Move rdi, stack:0x0
	129 ShiftStack 8
	130 Call ReloadedController.SetImageOverride, rcx, rdx, r8
	131 Return 
	132 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
