# System.Boolean IsAGoldMagnetAboutToSuck()

- 类：`Plant`
- 汇编行数：190

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	push rdi
	sub rsp,30h
	cmp byte ptr [184EEB67Bh],0
	mov rbx,rcx
	jne short 00000001806B2091h
	lea rcx,[184C7F5F0h]
	call 00000001804FEB70h
	lea rcx,[184C7F6C8h]
	call 00000001804FEB70h
	lea rcx,[184CA0500h]
	call 00000001804FEB70h
	mov byte ptr [184EEB67Bh],1
	mov rax,[rbx+18h]
	xor edi,edi
	movaps [rsp+20h],xmm6
	mov edx,edi
	test rax,rax
	je near ptr 00000001806B21B2h
	movss xmm6,dword ptr [183C33C40h]
	nop
	mov rcx,[rax+78h]
	test rcx,rcx
	je near ptr 00000001806B21B2h
	cmp edx,[rcx+28h]
	jge near ptr 00000001806B21A0h
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806B21B2h
	mov rcx,[rax+78h]
	test rcx,rcx
	je near ptr 00000001806B21B2h
	mov r8,[184C7F6C8h]
	mov edx,edi
	call 0000000182449330h
	test rax,rax
	je near ptr 00000001806B21B2h
	cmp dword ptr [rax+70h],11h
	jne short 00000001806B2118h
	cmp dword ptr [rax+88h],5
	je short 00000001806B217Ch
	cmp dword ptr [rax+88h],6
	je short 00000001806B217Ch
	cmp dword ptr [rax+88h],7
	je short 00000001806B217Ch
	cmp byte ptr [rax+3Ch],0
	jne short 00000001806B217Ch
	cmp dword ptr [rax+128h],2
	je short 00000001806B217Ch
	cmp byte ptr [rax+135h],0
	jne short 00000001806B217Ch
	cmp dword ptr [rax+70h],2Dh
	jne short 00000001806B217Ch
	cmp dword ptr [rax+88h],1Ah
	jne short 00000001806B217Ch
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B21B2h
	mov rdx,[184CA0500h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C7EF0h
	test al,al
	je short 00000001806B218Eh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B21B2h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78E0h
	comiss xmm6,xmm0
	ja short 00000001806B218Eh
	mov rax,[rbx+18h]
	inc edi
	mov edx,edi
	test rax,rax
	je short 00000001806B21B2h
	jmp near ptr 00000001806B20B0h
	mov al,1
	movaps xmm6,[rsp+20h]
	mov rbx,[rsp+40h]
	add rsp,30h
	pop rdi
	ret
	movaps xmm6,[rsp+20h]
	xor al,al
	mov rbx,[rsp+40h]
	add rsp,30h
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rdi
	004 ShiftStack -48
	005 Compare [0x184EEB67B], 0
	006 Move rbx, rcx
	007 JumpIfNotEqual {15}
	008 LoadAddress rcx, [0x184C7F5F0]
	009 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	010 LoadAddress rcx, [0x184C7F6C8]
	011 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	012 LoadAddress rcx, [0x184CA0500]
	013 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	014 Move [0x184EEB67B], 1
	015 Move rax, [rbx+24]
	016 Move rdi, 0
	017 Move stack:0x20, xmm6
	018 Move rdx, rdi
	019 Compare rax, 0
	020 JumpIfEqual {94}
	021 Move xmm6, [0x183C33C40]
	022 Nop 
	023 Move rcx, [rax+120]
	024 Compare rcx, 0
	025 JumpIfEqual {94}
	026 Compare rdx, [rcx+40]
	027 JumpIfGreaterOrEqual {87}
	028 Move rax, [rbx+24]
	029 Compare rax, 0
	030 JumpIfEqual {94}
	031 Move rcx, [rax+120]
	032 Compare rcx, 0
	033 JumpIfEqual {94}
	034 Move r8, [0x184C7F6C8]
	035 Move rdx, rdi
	036 Call 0x182449330, rcx, rdx
	037 Compare rax, 0
	038 JumpIfEqual {94}
	039 Compare [rax+112], 17
	040 JumpIfNotEqual {47}
	041 Compare [rax+136], 5
	042 JumpIfEqual {74}
	043 Compare [rax+136], 6
	044 JumpIfEqual {74}
	045 Compare [rax+136], 7
	046 JumpIfEqual {74}
	047 Compare [rax+60], 0
	048 JumpIfNotEqual {74}
	049 Compare [rax+296], 2
	050 JumpIfEqual {74}
	051 Compare [rax+309], 0
	052 JumpIfNotEqual {74}
	053 Compare [rax+112], 45
	054 JumpIfNotEqual {74}
	055 Compare [rax+136], 26
	056 JumpIfNotEqual {74}
	057 Move rcx, [rbx+320]
	058 Compare rcx, 0
	059 JumpIfEqual {94}
	060 Move rdx, "attract"
	061 Move r9, 0
	062 Move r8, 0
	063 Call ReloadedCharacterController.IsCurrentAnimationOnTrack, rcx, rdx, r8
	064 Compare rax, 0
	065 JumpIfEqual {80}
	066 Move rcx, [rbx+320]
	067 Compare rcx, 0
	068 JumpIfEqual {94}
	069 Move r8, 0
	070 Move rdx, 0
	071 Call ReloadedCharacterController.GetAnimationTimeOnTrack, rcx, rdx
	072 Compare xmm6, xmm0
	073 JumpIfGreater {80}
	074 Move rax, [rbx+24]
	075 Add rdi, rdi, 1
	076 Move rdx, rdi
	077 Compare rax, 0
	078 JumpIfEqual {94}
	079 Goto {23}
	080 Move rax, 1
	081 Move xmm6, stack:0x20
	082 Move rbx, stack:0x40
	083 ShiftStack 48
	084 Move rdi, stack:0x0
	085 ShiftStack 8
	086 Return rax
	087 Move xmm6, stack:0x20
	088 Move rax, 0
	089 Move rbx, stack:0x40
	090 ShiftStack 48
	091 Move rdi, stack:0x0
	092 ShiftStack 8
	093 Return rax
	094 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
