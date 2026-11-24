# Reloaded.Gameplay.TodParticleSystem AddAttachedParticle(System.Single thePosX, System.Single thePosY, System.Int32 theRenderPostition, Reloaded.Gameplay.ParticleEffect theEffect)

- 类：`Plant`
- 汇编行数：153

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	mov [rsp+10h],rsi
	push rdi
	sub rsp,50h
	cmp byte ptr [184EEB64Fh],0
	mov esi,r9d
	movaps [rsp+40h],xmm6
	mov rbx,rcx
	movaps [rsp+30h],xmm7
	movaps xmm6,xmm2
	movaps xmm7,xmm1
	jne short 00000001806AB261h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	mov byte ptr [184EEB64Fh],1
	mov rcx,[184C2D478h]
	mov rdi,[rbx+10h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806AB27Ah
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	jne short 00000001806AB292h
	xor edi,edi
	jmp near ptr 00000001806AB317h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806AB334h
	mov edx,[rbx+0D8h]
	xor r8d,r8d
	call 00000001807E1000h
	test rax,rax
	je short 00000001806AB2BCh
	xor edx,edx
	mov rcx,rax
	call 00000001806D7CD0h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806AB334h
	cvttss2si eax,xmm6
	xor edi,edi
	mov r9d,esi
	mov [rsp+28h],rdi
	movd xmm2,eax
	cvttss2si eax,xmm7
	cvtdq2ps xmm2,xmm2
	movd xmm1,eax
	mov eax,[rsp+80h]
	cvtdq2ps xmm1,xmm1
	mov [rsp+20h],eax
	call 00000001807D9B50h
	mov rdi,rax
	test rax,rax
	je short 00000001806AB317h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806AB334h
	xor r8d,r8d
	mov rdx,rax
	call 00000001807E0FA0h
	mov [rbx+0D8h],eax
	mov rbx,[rsp+60h]
	mov rax,rdi
	mov rsi,[rsp+68h]
	movaps xmm6,[rsp+40h]
	movaps xmm7,[rsp+30h]
	add rsp,50h
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 Move stack:0x10, rsi
	003 ShiftStack -8
	004 Move stack:0x0, rdi
	005 ShiftStack -80
	006 Compare [0x184EEB64F], 0
	007 Move rsi, r9
	008 Move stack:0x40, xmm6
	009 Move rbx, rcx
	010 Move stack:0x30, xmm7
	011 Move xmm6, xmm2
	012 Move xmm7, xmm1
	013 JumpIfNotEqual {17}
	014 LoadAddress rcx, [0x184C2D478]
	015 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	016 Move [0x184EEB64F], 1
	017 Move rcx, typeof(UnityEngine.Object)
	018 Move rdi, [rbx+16]
	019 Compare [rcx+228], 0
	020 JumpIfNotEqual {22}
	021 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	022 Move r8, 0
	023 Move rdx, 0
	024 Move rcx, rdi
	025 Call Object.op_Inequality, rcx, rdx, r8
	026 Compare rax, 0
	027 JumpIfNotEqual {30}
	028 Move rdi, 0
	029 Goto {66}
	030 Move rcx, [rbx+16]
	031 Compare rcx, 0
	032 JumpIfEqual {75}
	033 Move rdx, [rbx+216]
	034 Move r8, 0
	035 Call GameplayActivity.ParticleTryToGet, rcx, rdx
	036 Compare rax, 0
	037 JumpIfEqual {41}
	038 Move rdx, 0
	039 Move rcx, rax
	040 Call TodParticleSystem.ParticleSystemDie, rcx, rdx
	041 Move rcx, [rbx+16]
	042 Compare rcx, 0
	043 JumpIfEqual {75}
	044 NotImplemented "cvttss2si eax,xmm6"
	045 Move rdi, 0
	046 Move r9, rsi
	047 Move stack:0x28, rdi
	048 Move xmm2, rax
	049 NotImplemented "cvttss2si eax,xmm7"
	050 Move xmm2, xmm2
	051 Move xmm1, rax
	052 Move rax, stack:0x80
	053 Move xmm1, xmm1
	054 Move stack:0x20, rax
	055 Call GameplayActivity.AddTodParticle, rcx, xmm1, r8, r9, stack:0x0
	056 Move rdi, rax
	057 Compare rax, 0
	058 JumpIfEqual {66}
	059 Move rcx, [rbx+16]
	060 Compare rcx, 0
	061 JumpIfEqual {75}
	062 Move r8, 0
	063 Move rdx, rax
	064 Call GameplayActivity.ParticleGetID, rcx, rdx
	065 Move [rbx+216], rax
	066 Move rbx, stack:0x60
	067 Move rax, rdi
	068 Move rsi, stack:0x68
	069 Move xmm6, stack:0x40
	070 Move xmm7, stack:0x30
	071 ShiftStack 80
	072 Move rdi, stack:0x0
	073 ShiftStack 8
	074 Return rax
	075 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
